window.triggerFileInputClick = function (element) {
    element.click();
}

window.readFileContent = function (inputElement) {
    return new Promise((resolve, reject) => {
        const file = inputElement.files[0];
        const reader = new FileReader();
        reader.onload = function () {
            const buffer = reader.result;
            const extension = file.name.split('.').pop().toLowerCase();
            if (extension === 'pdf') {
                const pdf = pdfjsLib.getDocument(new Uint8Array(buffer));
                pdf.promise.then(function (doc) {
                    const numPages = doc.numPages;
                    doc.getPage(1).then(function (page) {
                        page.getTextContent().then(function (content) {
                            let text = '';
                            let fp = '';
                            for (let item of content.items) {
                                text += item.str + '\n';
                            }
                            const skills = extractTopSkills(text);
                            console.log(skills);

                            for (let d of skills) {
                                fp += d + '\n';
                            }
                            resolve(fp);
                        });
                    });
                });
            } else if (extension === 'docx') {
                mammoth.extractRawText({ arrayBuffer: buffer })
                    .then(resultObject => resolve(resultObject.value))
                    .catch(reject);
            } else {
                resolve(new TextDecoder().decode(buffer));
            }
        };
        reader.onerror = reject;
        reader.readAsArrayBuffer(file);
    });
}

function extractTopSkills(text) {
    const skillsStart = text.indexOf("Top Skills");
    const experienceStart = text.indexOf("Experience");
    const educationStart = text.indexOf("Education");

    // Determine the end of the skills section by finding the next section header
    let skillsEnd = Math.min(experienceStart, educationStart);
    if (experienceStart === -1) skillsEnd = educationStart;
    if (educationStart === -1) skillsEnd = experienceStart;

    if (skillsStart !== -1 && skillsEnd !== -1) {
        const skillsText = text.substring(skillsStart + "Top Skills".length, skillsEnd).trim();
        const skillsArray = skillsText.split('\n').filter(skill => skill.trim() !== '');
        return skillsArray;
    }
    return [];
}