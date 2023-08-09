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
                            for (let item of content.items) {
                                text += item.str;
                            }
                            resolve(text);
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
