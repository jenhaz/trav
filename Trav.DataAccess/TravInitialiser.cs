using System.Collections.Generic;
using System.Data.Entity;
using Trav.DataAccess.Countries;

namespace Trav.DataAccess
{
    public class TravInitialiser : DropCreateDatabaseIfModelChanges<TravContext>
    {
        protected override void Seed(TravContext context)
        {
            var countries = new List<CountryDao>
            {
                new CountryDao
                {
                    Name = "Afghanistan",
                    Code = "AF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Albania",
                    Code = "AL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Algeria",
                    Code = "DZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "American Samoa",
                    Code = "AS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Andorra",
                    Code = "AD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Angola",
                    Code = "AO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Anguilla",
                    Code = "AI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Antarctica",
                    Code = "AQ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Antigua & Barbuda",
                    Code = "AG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Argentina",
                    Code = "AR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Armenia",
                    Code = "AM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Aruba",
                    Code = "AW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Australia",
                    Code = "AU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Austria",
                    Code = "AT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Azerbaijan",
                    Code = "AZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bahrain",
                    Code = "BH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bangladesh",
                    Code = "BD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Barbados",
                    Code = "BB",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Belarus",
                    Code = "BY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Belgium",
                    Code = "BE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Belize",
                    Code = "BZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Benin",
                    Code = "BJ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bermuda",
                    Code = "BM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bhutan",
                    Code = "BT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bolivia",
                    Code = "BO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bosnia & Herzegovina",
                    Code = "BA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Botswana",
                    Code = "BW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bouvet Island",
                    Code = "BV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Brazil",
                    Code = "BR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "British Indian Ocean Territory",
                    Code = "IO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "British Virgin Islands",
                    Code = "VG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Brunei",
                    Code = "BN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bulgaria",
                    Code = "BG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Burkina Faso",
                    Code = "BF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Burundi",
                    Code = "BI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cambodia",
                    Code = "KH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cameroon",
                    Code = "CM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Canada",
                    Code = "CA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cape Verde",
                    Code = "CV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cayman Islands",
                    Code = "KY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Central African Republic",
                    Code = "CF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Chad",
                    Code = "TD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Chile",
                    Code = "CL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "China",
                    Code = "CN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Christmas Island",
                    Code = "CX",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cocos Island",
                    Code = "CC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Colombia",
                    Code = "CO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Comoros",
                    Code = "KM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Congo",
                    Code = "CG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Democratic Republic of the Congo",
                    Code = "CD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cook Islands",
                    Code = "CK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Costa Rica",
                    Code = "CR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cote d'Ivoire",
                    Code = "CI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Croatia",
                    Code = "HR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cuba",
                    Code = "CU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Cyprus",
                    Code = "CY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Czech Republic",
                    Code = "CZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Denmark",
                    Code = "DK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Djibouti",
                    Code = "DJ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Dominica",
                    Code = "DM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Dominican Republic",
                    Code = "DO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Ecuador",
                    Code = "EC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Egypt",
                    Code = "EG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "El Salvador",
                    Code = "SV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Equitorial Guinea",
                    Code = "GQ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Eritrea",
                    Code = "ER",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Estonia",
                    Code = "EE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Ethiopia",
                    Code = "ET",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Falkland Islands",
                    Code = "FK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Faroe Islands",
                    Code = "FO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Fiji",
                    Code = "FJ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Finland",
                    Code = "FI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "France",
                    Code = "FR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "French Guiana",
                    Code = "GF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "French Polynesia",
                    Code = "PF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "French Southern & Antarctic Lands",
                    Code = "TF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Gabon",
                    Code = "GA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Gaza Strip",
                    Code = "PS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Georgia",
                    Code = "GE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Germany",
                    Code = "DE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Ghana",
                    Code = "GH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Gibraltar",
                    Code = "GI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Greece",
                    Code = "GR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Greenland",
                    Code = "GL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Grenada",
                    Code = "GD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guadeloupe",
                    Code = "GP",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guam",
                    Code = "GU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guatemala",
                    Code = "GT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guinea",
                    Code = "GN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guinea-Bissau",
                    Code = "GW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Guyana",
                    Code = "GY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Haiti",
                    Code = "HT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Heard Island & McDonald Islands",
                    Code = "HM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Honduras",
                    Code = "HN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Hungary",
                    Code = "HU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Iceland",
                    Code = "IS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "India",
                    Code = "IN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Indonesia",
                    Code = "ID",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Iran",
                    Code = "IR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Iraq",
                    Code = "IQ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Ireland",
                    Code = "IE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Israel",
                    Code = "IL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Italy",
                    Code = "IT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Jamaica",
                    Code = "JM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Jan Mayen",
                    Code = "SJ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Japan",
                    Code = "JP",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Jarvis Island",
                    Code = "UM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Jordan",
                    Code = "JO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Kazakhstan",
                    Code = "KZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Kenya",
                    Code = "KE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Kiribati",
                    Code = "KI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Kuwait",
                    Code = "KW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Kyrgyzstan",
                    Code = "KG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Laos",
                    Code = "LA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Latvia",
                    Code = "LV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Lebanon",
                    Code = "LB",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Lesotho",
                    Code = "LS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Liberia",
                    Code = "LR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Libya",
                    Code = "LY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Liechtenstein",
                    Code = "LI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Lithuania",
                    Code = "LT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Luxembourg",
                    Code = "LU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Macedonia",
                    Code = "MK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Madagascar",
                    Code = "MG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Malawi",
                    Code = "MW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Malaysia",
                    Code = "MY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Maldives",
                    Code = "MV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mali",
                    Code = "ML",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Malta",
                    Code = "MT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Marshall Islands",
                    Code = "MH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Martinique",
                    Code = "MQ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mauritania",
                    Code = "MR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mauritius",
                    Code = "MU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mayotte",
                    Code = "YT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mexico",
                    Code = "MX",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Micronesia",
                    Code = "FM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Moldova",
                    Code = "MD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Monaco",
                    Code = "MC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mongolia",
                    Code = "MN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Montenegro",
                    Code = "ME",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Montserrat",
                    Code = "MS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Morocco",
                    Code = "MA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Mozambique",
                    Code = "MZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Myanmar",
                    Code = "MM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Namibia",
                    Code = "NA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Nauru",
                    Code = "NR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Nepal",
                    Code = "NP",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Netherlands",
                    Code = "NL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Netherlands Antilles",
                    Code = "AN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "New Caledonia",
                    Code = "NC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "New Zealand",
                    Code = "NZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Nicaragua",
                    Code = "NI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Niger",
                    Code = "NE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Nigeria",
                    Code = "NG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Niue",
                    Code = "NU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Norfolk Island",
                    Code = "NF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "North Korea",
                    Code = "KP",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Northern Mariana Islands",
                    Code = "MP",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Norway",
                    Code = "NO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Oman",
                    Code = "OM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Pakistan",
                    Code = "PK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Palau",
                    Code = "PW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Panama",
                    Code = "PA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Papua New Guinea",
                    Code = "PG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Paraguay",
                    Code = "PY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Peru",
                    Code = "PE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Philippines",
                    Code = "PH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Pitcairn Islands",
                    Code = "PN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Poland",
                    Code = "PL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Portugal",
                    Code = "PT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Puerto Rico",
                    Code = "PR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Qatar",
                    Code = "QA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Reunion",
                    Code = "RE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Romania",
                    Code = "RO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Russia",
                    Code = "RU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Rwanda",
                    Code = "RW",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Samoa",
                    Code = "WS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "San Marino",
                    Code = "SM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Sao Tome & Principe",
                    Code = "ST",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Saudi Arabia",
                    Code = "SA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Senegal",
                    Code = "SN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Serbia",
                    Code = "RS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Seychelles",
                    Code = "SC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Sierra Leone",
                    Code = "SL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Singapore",
                    Code = "SG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Slovakia",
                    Code = "SK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Slovenia",
                    Code = "SI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Solomon Islands",
                    Code = "SB",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Somalia",
                    Code = "SO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "South Africa",
                    Code = "ZA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "South Georgia & the South Sandwich Islands",
                    Code = "GS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "South Korea",
                    Code = "KR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Spain",
                    Code = "ES",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Sri Lanka",
                    Code = "LK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "St Helena",
                    Code = "SH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "St Kitts & Nevis",
                    Code = "KN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "St Lucia",
                    Code = "LC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "St Pierre & Miquelon",
                    Code = "PM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "St Vincent & the Grenadines",
                    Code = "VC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Sudan",
                    Code = "SD",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Suriname",
                    Code = "SR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Swaziland",
                    Code = "SZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Sweden",
                    Code = "SE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Switzerland",
                    Code = "CH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Syria",
                    Code = "SY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tajikistan",
                    Code = "TJ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tanzania",
                    Code = "TZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Thailand",
                    Code = "TH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Bahamas",
                    Code = "BS",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Gambia",
                    Code = "GM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Timor-Leste",
                    Code = "TL",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Togo",
                    Code = "TG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tokelau",
                    Code = "TK",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tonga",
                    Code = "TO",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Trinidad & Tobago",
                    Code = "TT",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tunisia",
                    Code = "TN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Turkey",
                    Code = "TR",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Turkmenistan",
                    Code = "TM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Turks & Caicos Islands",
                    Code = "TC",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Tuvalu",
                    Code = "TV",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Uganda",
                    Code = "UG",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Ukraine",
                    Code = "UA",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "United Arab Emirates",
                    Code = "AE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "United States of America",
                    Code = "US",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Uruguay",
                    Code = "UY",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Uzbekistan",
                    Code = "UZ",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Vanuatu",
                    Code = "VU",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Venezuela",
                    Code = "VE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Vietnam",
                    Code = "VN",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Virgin Islands",
                    Code = "VI",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Wallis & Futuna",
                    Code = "WF",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Western Sahara",
                    Code = "EH",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Yemen",
                    Code = "YE",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Zambia",
                    Code = "ZM",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Zimbabwe",
                    Code = "ZW",
                    Visited = false
                },
                //to do: borders for map for 4 uk countries
                //new CountryDao
                //{
                //    Name = "United Kingdom",
                //    Code = "GB",
                //    Visited = false
                //},
                new CountryDao
                {
                    Name = "England",
                    Code = "GB",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Wales",
                    Code = "GB",
                    Visited = false
                },
                new CountryDao
                {
                    Name = "Scotland",
                    Code = "GB",
                    Visited = false
                },
                new CountryDao
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