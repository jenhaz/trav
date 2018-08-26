using System.Collections.Generic;
using System.Data.Entity;
using Trav.Models;

namespace Trav.DAL
{
    public class TravInitialiser : DropCreateDatabaseIfModelChanges<TravContext>
    {
        protected override void Seed(TravContext context)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Name = "Afghanistan",
                    Code = "AF",
                    Visited = false
                },
                new Country
                {
                    Name = "Albania",
                    Code = "AL",
                    Visited = false
                },
                new Country
                {
                    Name = "Algeria",
                    Code = "DZ",
                    Visited = false
                },
                new Country
                {
                    Name = "American Samoa",
                    Code = "AS",
                    Visited = false
                },
                new Country
                {
                    Name = "Andorra",
                    Code = "AD",
                    Visited = false
                },
                new Country
                {
                    Name = "Angola",
                    Code = "AO",
                    Visited = false
                },
                new Country
                {
                    Name = "Anguilla",
                    Code = "AI",
                    Visited = false
                },
                new Country
                {
                    Name = "Antarctica",
                    Code = "AQ",
                    Visited = false
                },
                new Country
                {
                    Name = "Antigua & Barbuda",
                    Code = "AG",
                    Visited = false
                },
                new Country
                {
                    Name = "Argentina",
                    Code = "AR",
                    Visited = false
                },
                new Country
                {
                    Name = "Armenia",
                    Code = "AM",
                    Visited = false
                },
                new Country
                {
                    Name = "Aruba",
                    Code = "AW",
                    Visited = false
                },
                new Country
                {
                    Name = "Australia",
                    Code = "AU",
                    Visited = false
                },
                new Country
                {
                    Name = "Austria",
                    Code = "AT",
                    Visited = false
                },
                new Country
                {
                    Name = "Azerbaijan",
                    Code = "AZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Bahrain",
                    Code = "BH",
                    Visited = false
                },
                new Country
                {
                    Name = "Bangladesh",
                    Code = "BD",
                    Visited = false
                },
                new Country
                {
                    Name = "Barbados",
                    Code = "BB",
                    Visited = false
                },
                new Country
                {
                    Name = "Belarus",
                    Code = "BY",
                    Visited = false
                },
                new Country
                {
                    Name = "Belgium",
                    Code = "BE",
                    Visited = false
                },
                new Country
                {
                    Name = "Belize",
                    Code = "BZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Benin",
                    Code = "BJ",
                    Visited = false
                },
                new Country
                {
                    Name = "Bermuda",
                    Code = "BM",
                    Visited = false
                },
                new Country
                {
                    Name = "Bhutan",
                    Code = "BT",
                    Visited = false
                },
                new Country
                {
                    Name = "Bolivia",
                    Code = "BO",
                    Visited = false
                },
                new Country
                {
                    Name = "Bosnia & Herzegovina",
                    Code = "BA",
                    Visited = false
                },
                new Country
                {
                    Name = "Botswana",
                    Code = "BW",
                    Visited = false
                },
                new Country
                {
                    Name = "Bouvet Island",
                    Code = "BV",
                    Visited = false
                },
                new Country
                {
                    Name = "Brazil",
                    Code = "BR",
                    Visited = false
                },
                new Country
                {
                    Name = "British Indian Ocean Territory",
                    Code = "IO",
                    Visited = false
                },
                new Country
                {
                    Name = "British Virgin Islands",
                    Code = "VG",
                    Visited = false
                },
                new Country
                {
                    Name = "Brunei",
                    Code = "BN",
                    Visited = false
                },
                new Country
                {
                    Name = "Bulgaria",
                    Code = "BG",
                    Visited = false
                },
                new Country
                {
                    Name = "Burkina Faso",
                    Code = "BF",
                    Visited = false
                },
                new Country
                {
                    Name = "Burundi",
                    Code = "BI",
                    Visited = false
                },
                new Country
                {
                    Name = "Cambodia",
                    Code = "KH",
                    Visited = false
                },
                new Country
                {
                    Name = "Cameroon",
                    Code = "CM",
                    Visited = false
                },
                new Country
                {
                    Name = "Canada",
                    Code = "CA",
                    Visited = false
                },
                new Country
                {
                    Name = "Cape Verde",
                    Code = "CV",
                    Visited = false
                },
                new Country
                {
                    Name = "Cayman Islands",
                    Code = "KY",
                    Visited = false
                },
                new Country
                {
                    Name = "Central African Republic",
                    Code = "CF",
                    Visited = false
                },
                new Country
                {
                    Name = "Chad",
                    Code = "TD",
                    Visited = false
                },
                new Country
                {
                    Name = "Chile",
                    Code = "CL",
                    Visited = false
                },
                new Country
                {
                    Name = "China",
                    Code = "CN",
                    Visited = false
                },
                new Country
                {
                    Name = "Christmas Island",
                    Code = "CX",
                    Visited = false
                },
                new Country
                {
                    Name = "Cocos Island",
                    Code = "CC",
                    Visited = false
                },
                new Country
                {
                    Name = "Colombia",
                    Code = "CO",
                    Visited = false
                },
                new Country
                {
                    Name = "Comoros",
                    Code = "KM",
                    Visited = false
                },
                new Country
                {
                    Name = "Congo",
                    Code = "CG",
                    Visited = false
                },
                new Country
                {
                    Name = "Democratic Republic of the Congo",
                    Code = "CD",
                    Visited = false
                },
                new Country
                {
                    Name = "Cook Islands",
                    Code = "CK",
                    Visited = false
                },
                new Country
                {
                    Name = "Costa Rica",
                    Code = "CR",
                    Visited = false
                },
                new Country
                {
                    Name = "Cote d'Ivoire",
                    Code = "CI",
                    Visited = false
                },
                new Country
                {
                    Name = "Croatia",
                    Code = "HR",
                    Visited = false
                },
                new Country
                {
                    Name = "Cuba",
                    Code = "CU",
                    Visited = false
                },
                new Country
                {
                    Name = "Cyprus",
                    Code = "CY",
                    Visited = false
                },
                new Country
                {
                    Name = "Czech Republic",
                    Code = "CZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Denmark",
                    Code = "DK",
                    Visited = false
                },
                new Country
                {
                    Name = "Djibouti",
                    Code = "DJ",
                    Visited = false
                },
                new Country
                {
                    Name = "Dominica",
                    Code = "DM",
                    Visited = false
                },
                new Country
                {
                    Name = "Dominican Republic",
                    Code = "DO",
                    Visited = false
                },
                new Country
                {
                    Name = "Ecuador",
                    Code = "EC",
                    Visited = false
                },
                new Country
                {
                    Name = "Egypt",
                    Code = "EG",
                    Visited = false
                },
                new Country
                {
                    Name = "El Salvador",
                    Code = "SV",
                    Visited = false
                },
                new Country
                {
                    Name = "Equitorial Guinea",
                    Code = "GQ",
                    Visited = false
                },
                new Country
                {
                    Name = "Eritrea",
                    Code = "ER",
                    Visited = false
                },
                new Country
                {
                    Name = "Estonia",
                    Code = "EE",
                    Visited = false
                },
                new Country
                {
                    Name = "Ethiopia",
                    Code = "ET",
                    Visited = false
                },
                new Country
                {
                    Name = "Falkland Islands",
                    Code = "FK",
                    Visited = false
                },
                new Country
                {
                    Name = "Faroe Islands",
                    Code = "FO",
                    Visited = false
                },
                new Country
                {
                    Name = "Fiji",
                    Code = "FJ",
                    Visited = false
                },
                new Country
                {
                    Name = "Finland",
                    Code = "FI",
                    Visited = false
                },
                new Country
                {
                    Name = "France",
                    Code = "FR",
                    Visited = false
                },
                new Country
                {
                    Name = "French Guiana",
                    Code = "GF",
                    Visited = false
                },
                new Country
                {
                    Name = "French Polynesia",
                    Code = "PF",
                    Visited = false
                },
                new Country
                {
                    Name = "French Southern & Antarctic Lands",
                    Code = "TF",
                    Visited = false
                },
                new Country
                {
                    Name = "Gabon",
                    Code = "GA",
                    Visited = false
                },
                new Country
                {
                    Name = "Gaza Strip",
                    Code = "PS",
                    Visited = false
                },
                new Country
                {
                    Name = "Georgia",
                    Code = "GE",
                    Visited = false
                },
                new Country
                {
                    Name = "Germany",
                    Code = "DE",
                    Visited = false
                },
                new Country
                {
                    Name = "Ghana",
                    Code = "GH",
                    Visited = false
                },
                new Country
                {
                    Name = "Gibraltar",
                    Code = "GI",
                    Visited = false
                },
                new Country
                {
                    Name = "Greece",
                    Code = "GR",
                    Visited = false
                },
                new Country
                {
                    Name = "Greenland",
                    Code = "GL",
                    Visited = false
                },
                new Country
                {
                    Name = "Grenada",
                    Code = "GD",
                    Visited = false
                },
                new Country
                {
                    Name = "Guadeloupe",
                    Code = "GP",
                    Visited = false
                },
                new Country
                {
                    Name = "Guam",
                    Code = "GU",
                    Visited = false
                },
                new Country
                {
                    Name = "Guatemala",
                    Code = "GT",
                    Visited = false
                },
                new Country
                {
                    Name = "Guinea",
                    Code = "GN",
                    Visited = false
                },
                new Country
                {
                    Name = "Guinea-Bissau",
                    Code = "GW",
                    Visited = false
                },
                new Country
                {
                    Name = "Guyana",
                    Code = "GY",
                    Visited = false
                },
                new Country
                {
                    Name = "Haiti",
                    Code = "HT",
                    Visited = false
                },
                new Country
                {
                    Name = "Heard Island & McDonald Islands",
                    Code = "HM",
                    Visited = false
                },
                new Country
                {
                    Name = "Honduras",
                    Code = "HN",
                    Visited = false
                },
                new Country
                {
                    Name = "Hungary",
                    Code = "HU",
                    Visited = false
                },
                new Country
                {
                    Name = "Iceland",
                    Code = "IS",
                    Visited = false
                },
                new Country
                {
                    Name = "India",
                    Code = "IN",
                    Visited = false
                },
                new Country
                {
                    Name = "Indonesia",
                    Code = "ID",
                    Visited = false
                },
                new Country
                {
                    Name = "Iran",
                    Code = "IR",
                    Visited = false
                },
                new Country
                {
                    Name = "Iraq",
                    Code = "IQ",
                    Visited = false
                },
                new Country
                {
                    Name = "Ireland",
                    Code = "IE",
                    Visited = false
                },
                new Country
                {
                    Name = "Israel",
                    Code = "IL",
                    Visited = false
                },
                new Country
                {
                    Name = "Italy",
                    Code = "IT",
                    Visited = false
                },
                new Country
                {
                    Name = "Jamaica",
                    Code = "JM",
                    Visited = false
                },
                new Country
                {
                    Name = "Jan Mayen",
                    Code = "SJ",
                    Visited = false
                },
                new Country
                {
                    Name = "Japan",
                    Code = "JP",
                    Visited = false
                },
                new Country
                {
                    Name = "Jarvis Island",
                    Code = "UM",
                    Visited = false
                },
                new Country
                {
                    Name = "Jordan",
                    Code = "JO",
                    Visited = false
                },
                new Country
                {
                    Name = "Kazakhstan",
                    Code = "KZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Kenya",
                    Code = "KE",
                    Visited = false
                },
                new Country
                {
                    Name = "Kiribati",
                    Code = "KI",
                    Visited = false
                },
                new Country
                {
                    Name = "Kuwait",
                    Code = "KW",
                    Visited = false
                },
                new Country
                {
                    Name = "Kyrgyzstan",
                    Code = "KG",
                    Visited = false
                },
                new Country
                {
                    Name = "Laos",
                    Code = "LA",
                    Visited = false
                },
                new Country
                {
                    Name = "Latvia",
                    Code = "LV",
                    Visited = false
                },
                new Country
                {
                    Name = "Lebanon",
                    Code = "LB",
                    Visited = false
                },
                new Country
                {
                    Name = "Lesotho",
                    Code = "LS",
                    Visited = false
                },
                new Country
                {
                    Name = "Liberia",
                    Code = "LR",
                    Visited = false
                },
                new Country
                {
                    Name = "Libya",
                    Code = "LY",
                    Visited = false
                },
                new Country
                {
                    Name = "Liechtenstein",
                    Code = "LI",
                    Visited = false
                },
                new Country
                {
                    Name = "Lithuania",
                    Code = "LT",
                    Visited = false
                },
                new Country
                {
                    Name = "Luxembourg",
                    Code = "LU",
                    Visited = false
                },
                new Country
                {
                    Name = "Macedonia",
                    Code = "MK",
                    Visited = false
                },
                new Country
                {
                    Name = "Madagascar",
                    Code = "MG",
                    Visited = false
                },
                new Country
                {
                    Name = "Malawi",
                    Code = "MW",
                    Visited = false
                },
                new Country
                {
                    Name = "Malaysia",
                    Code = "MY",
                    Visited = false
                },
                new Country
                {
                    Name = "Maldives",
                    Code = "MV",
                    Visited = false
                },
                new Country
                {
                    Name = "Mali",
                    Code = "ML",
                    Visited = false
                },
                new Country
                {
                    Name = "Malta",
                    Code = "MT",
                    Visited = false
                },
                new Country
                {
                    Name = "Marshall Islands",
                    Code = "MH",
                    Visited = false
                },
                new Country
                {
                    Name = "Martinique",
                    Code = "MQ",
                    Visited = false
                },
                new Country
                {
                    Name = "Mauritania",
                    Code = "MR",
                    Visited = false
                },
                new Country
                {
                    Name = "Mauritius",
                    Code = "MU",
                    Visited = false
                },
                new Country
                {
                    Name = "Mayotte",
                    Code = "YT",
                    Visited = false
                },
                new Country
                {
                    Name = "Mexico",
                    Code = "MX",
                    Visited = false
                },
                new Country
                {
                    Name = "Micronesia",
                    Code = "FM",
                    Visited = false
                },
                new Country
                {
                    Name = "Moldova",
                    Code = "MD",
                    Visited = false
                },
                new Country
                {
                    Name = "Monaco",
                    Code = "MC",
                    Visited = false
                },
                new Country
                {
                    Name = "Mongolia",
                    Code = "MN",
                    Visited = false
                },
                new Country
                {
                    Name = "Montenegro",
                    Code = "ME",
                    Visited = false
                },
                new Country
                {
                    Name = "Montserrat",
                    Code = "MS",
                    Visited = false
                },
                new Country
                {
                    Name = "Morocco",
                    Code = "MA",
                    Visited = false
                },
                new Country
                {
                    Name = "Mozambique",
                    Code = "MZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Myanmar",
                    Code = "MM",
                    Visited = false
                },
                new Country
                {
                    Name = "Namibia",
                    Code = "NA",
                    Visited = false
                },
                new Country
                {
                    Name = "Nauru",
                    Code = "NR",
                    Visited = false
                },
                new Country
                {
                    Name = "Nepal",
                    Code = "NP",
                    Visited = false
                },
                new Country
                {
                    Name = "Netherlands",
                    Code = "NL",
                    Visited = false
                },
                new Country
                {
                    Name = "Netherlands Antilles",
                    Code = "AN",
                    Visited = false
                },
                new Country
                {
                    Name = "New Caledonia",
                    Code = "NC",
                    Visited = false
                },
                new Country
                {
                    Name = "New Zealand",
                    Code = "NZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Nicaragua",
                    Code = "NI",
                    Visited = false
                },
                new Country
                {
                    Name = "Niger",
                    Code = "NE",
                    Visited = false
                },
                new Country
                {
                    Name = "Nigeria",
                    Code = "NG",
                    Visited = false
                },
                new Country
                {
                    Name = "Niue",
                    Code = "NU",
                    Visited = false
                },
                new Country
                {
                    Name = "Norfolk Island",
                    Code = "NF",
                    Visited = false
                },
                new Country
                {
                    Name = "North Korea",
                    Code = "KP",
                    Visited = false
                },
                new Country
                {
                    Name = "Northern Mariana Islands",
                    Code = "MP",
                    Visited = false
                },
                new Country
                {
                    Name = "Norway",
                    Code = "NO",
                    Visited = false
                },
                new Country
                {
                    Name = "Oman",
                    Code = "OM",
                    Visited = false
                },
                new Country
                {
                    Name = "Pakistan",
                    Code = "PK",
                    Visited = false
                },
                new Country
                {
                    Name = "Palau",
                    Code = "PW",
                    Visited = false
                },
                new Country
                {
                    Name = "Panama",
                    Code = "PA",
                    Visited = false
                },
                new Country
                {
                    Name = "Papua New Guinea",
                    Code = "PG",
                    Visited = false
                },
                new Country
                {
                    Name = "Paraguay",
                    Code = "PY",
                    Visited = false
                },
                new Country
                {
                    Name = "Peru",
                    Code = "PE",
                    Visited = false
                },
                new Country
                {
                    Name = "Philippines",
                    Code = "PH",
                    Visited = false
                },
                new Country
                {
                    Name = "Pitcairn Islands",
                    Code = "PN",
                    Visited = false
                },
                new Country
                {
                    Name = "Poland",
                    Code = "PL",
                    Visited = false
                },
                new Country
                {
                    Name = "Portugal",
                    Code = "PT",
                    Visited = false
                },
                new Country
                {
                    Name = "Puerto Rico",
                    Code = "PR",
                    Visited = false
                },
                new Country
                {
                    Name = "Qatar",
                    Code = "QA",
                    Visited = false
                },
                new Country
                {
                    Name = "Reunion",
                    Code = "RE",
                    Visited = false
                },
                new Country
                {
                    Name = "Romania",
                    Code = "RO",
                    Visited = false
                },
                new Country
                {
                    Name = "Russia",
                    Code = "RU",
                    Visited = false
                },
                new Country
                {
                    Name = "Rwanda",
                    Code = "RW",
                    Visited = false
                },
                new Country
                {
                    Name = "Samoa",
                    Code = "WS",
                    Visited = false
                },
                new Country
                {
                    Name = "San Marino",
                    Code = "SM",
                    Visited = false
                },
                new Country
                {
                    Name = "Sao Tome & Principe",
                    Code = "ST",
                    Visited = false
                },
                new Country
                {
                    Name = "Saudi Arabia",
                    Code = "SA",
                    Visited = false
                },
                new Country
                {
                    Name = "Senegal",
                    Code = "SN",
                    Visited = false
                },
                new Country
                {
                    Name = "Serbia",
                    Code = "RS",
                    Visited = false
                },
                new Country
                {
                    Name = "Seychelles",
                    Code = "SC",
                    Visited = false
                },
                new Country
                {
                    Name = "Sierra Leone",
                    Code = "SL",
                    Visited = false
                },
                new Country
                {
                    Name = "Singapore",
                    Code = "SG",
                    Visited = false
                },
                new Country
                {
                    Name = "Slovakia",
                    Code = "SK",
                    Visited = false
                },
                new Country
                {
                    Name = "Slovenia",
                    Code = "SI",
                    Visited = false
                },
                new Country
                {
                    Name = "Solomon Islands",
                    Code = "SB",
                    Visited = false
                },
                new Country
                {
                    Name = "Somalia",
                    Code = "SO",
                    Visited = false
                },
                new Country
                {
                    Name = "South Africa",
                    Code = "ZA",
                    Visited = false
                },
                new Country
                {
                    Name = "South Georgia & the South Sandwich Islands",
                    Code = "GS",
                    Visited = false
                },
                new Country
                {
                    Name = "South Korea",
                    Code = "KR",
                    Visited = false
                },
                new Country
                {
                    Name = "Spain",
                    Code = "ES",
                    Visited = false
                },
                new Country
                {
                    Name = "Sri Lanka",
                    Code = "LK",
                    Visited = false
                },
                new Country
                {
                    Name = "St Helena",
                    Code = "SH",
                    Visited = false
                },
                new Country
                {
                    Name = "St Kitts & Nevis",
                    Code = "KN",
                    Visited = false
                },
                new Country
                {
                    Name = "St Lucia",
                    Code = "LC",
                    Visited = false
                },
                new Country
                {
                    Name = "St Pierre & Miquelon",
                    Code = "PM",
                    Visited = false
                },
                new Country
                {
                    Name = "St Vincent & the Grenadines",
                    Code = "VC",
                    Visited = false
                },
                new Country
                {
                    Name = "Sudan",
                    Code = "SD",
                    Visited = false
                },
                new Country
                {
                    Name = "Suriname",
                    Code = "SR",
                    Visited = false
                },
                new Country
                {
                    Name = "Swaziland",
                    Code = "SZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Sweden",
                    Code = "SE",
                    Visited = false
                },
                new Country
                {
                    Name = "Switzerland",
                    Code = "CH",
                    Visited = false
                },
                new Country
                {
                    Name = "Syria",
                    Code = "SY",
                    Visited = false
                },
                new Country
                {
                    Name = "Tajikistan",
                    Code = "TJ",
                    Visited = false
                },
                new Country
                {
                    Name = "Tanzania",
                    Code = "TZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Thailand",
                    Code = "TH",
                    Visited = false
                },
                new Country
                {
                    Name = "Bahamas",
                    Code = "BS",
                    Visited = false
                },
                new Country
                {
                    Name = "Gambia",
                    Code = "GM",
                    Visited = false
                },
                new Country
                {
                    Name = "Timor-Leste",
                    Code = "TL",
                    Visited = false
                },
                new Country
                {
                    Name = "Togo",
                    Code = "TG",
                    Visited = false
                },
                new Country
                {
                    Name = "Tokelau",
                    Code = "TK",
                    Visited = false
                },
                new Country
                {
                    Name = "Tonga",
                    Code = "TO",
                    Visited = false
                },
                new Country
                {
                    Name = "Trinidad & Tobago",
                    Code = "TT",
                    Visited = false
                },
                new Country
                {
                    Name = "Tunisia",
                    Code = "TN",
                    Visited = false
                },
                new Country
                {
                    Name = "Turkey",
                    Code = "TR",
                    Visited = false
                },
                new Country
                {
                    Name = "Turkmenistan",
                    Code = "TM",
                    Visited = false
                },
                new Country
                {
                    Name = "Turks & Caicos Islands",
                    Code = "TC",
                    Visited = false
                },
                new Country
                {
                    Name = "Tuvalu",
                    Code = "TV",
                    Visited = false
                },
                new Country
                {
                    Name = "Uganda",
                    Code = "UG",
                    Visited = false
                },
                new Country
                {
                    Name = "Ukraine",
                    Code = "UA",
                    Visited = false
                },
                new Country
                {
                    Name = "United Arab Emirates",
                    Code = "AE",
                    Visited = false
                },
                new Country
                {
                    Name = "United States of America",
                    Code = "US",
                    Visited = false
                },
                new Country
                {
                    Name = "Uruguay",
                    Code = "UY",
                    Visited = false
                },
                new Country
                {
                    Name = "Uzbekistan",
                    Code = "UZ",
                    Visited = false
                },
                new Country
                {
                    Name = "Vanuatu",
                    Code = "VU",
                    Visited = false
                },
                new Country
                {
                    Name = "Venezuela",
                    Code = "VE",
                    Visited = false
                },
                new Country
                {
                    Name = "Vietnam",
                    Code = "VN",
                    Visited = false
                },
                new Country
                {
                    Name = "Virgin Islands",
                    Code = "VI",
                    Visited = false
                },
                new Country
                {
                    Name = "Wallis & Futuna",
                    Code = "WF",
                    Visited = false
                },
                new Country
                {
                    Name = "Western Sahara",
                    Code = "EH",
                    Visited = false
                },
                new Country
                {
                    Name = "Yemen",
                    Code = "YE",
                    Visited = false
                },
                new Country
                {
                    Name = "Zambia",
                    Code = "ZM",
                    Visited = false
                },
                new Country
                {
                    Name = "Zimbabwe",
                    Code = "ZW",
                    Visited = false
                },
                //to do: borders for map for 4 uk countries
                //new Country
                //{
                //    Name = "United Kingdom",
                //    Code = "GB",
                //    Visited = false
                //},
                new Country
                {
                    Name = "England",
                    Code = "GB",
                    Visited = false
                },
                new Country
                {
                    Name = "Wales",
                    Code = "GB",
                    Visited = false
                },
                new Country
                {
                    Name = "Scotland",
                    Code = "GB",
                    Visited = false
                },
                new Country
                {
                    Name = "Northern Ireland",
                    Code = "GB",
                    Visited = false
                }
            };

            countries.ForEach(x => context.Countries.Add(x));
            context.SaveChanges();
        }
    }
}