using System.Diagnostics.Metrics;

namespace hr_bot_webapp_v2.Data
{
    public class RateLimitExceededResponse
    {
        public string Message { get; set; }
    }

    public class IPGeoLocationResponse
    {
        public string Ip { get; set; }
        public string Type { get; set; }
        public Location Location { get; set; }
        public string Postcode { get; set; }
        public Area Area { get; set; }
        public Asn Asn { get; set; }
        public City City { get; set; }
        public Continent? Continent { get; set; }
        public Country? Country { get; set; }
        public Currency? Currency { get; set; }
        public Security Security { get; set; }
        public Time Time { get; set; }
        public string Status { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Area
    {
        public string Code { get; set; }
        public int Geonameid { get; set; }
        public string Name { get; set; }
    }

    public class Asn
    {
        public int Number { get; set; }
        public string Organisation { get; set; }
    }

    public class City
    {
        public int Geonameid { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }

    public class Continent
    {
        public int Geonameid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class Country
    {
        public int Geonameid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
        public string Area_Size { get; set; }
        public long Population { get; set; }
        public string Phone_Code { get; set; }
        public bool Is_In_Eu { get; set; }
        public Languages? Languages { get; set; }
        public Flag? Flag { get; set; }
        public string Tld { get; set; }
    }

    public class Languages
    {
        public string Tl { get; set; }
        public string En { get; set; }
        public string Fil { get; set; }
        public string Ceb { get; set; }
        public string Tgl { get; set; }
        public string Ilo { get; set; }
        public string Hil { get; set; }
        public string War { get; set; }
        public string Pam { get; set; }
        public string Bik { get; set; }
        public string Pag { get; set; }
    }

    public class Flag
    {
        public string File { get; set; }
        public string Emoji { get; set; }
        public string Unicode { get; set; }
    }

    public class Currency
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Security
    {
        public bool Is_Tor { get; set; }
        public bool Is_Proxy { get; set; }
        public bool Is_Crawler { get; set; }
        public bool Is_Threat { get; set; }
        public bool Is_Thread { get; set; }
    }

    public class Time
    {
        public string Timezone { get; set; }
        public int Gtm_Offset { get; set; }
        public int Gmt_Offset { get; set; }
        public bool Is_Daylight_Saving { get; set; }
        public string Code { get; set; }
    }
}
