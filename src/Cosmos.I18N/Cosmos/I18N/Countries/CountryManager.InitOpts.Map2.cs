using System.Collections.Generic;

namespace Cosmos.I18N.Countries
{
    public static partial class CountryManager
    {
        private static partial class InitOpts
        {
            public static Dictionary<CountryCode, Country> Map2 = new Dictionary<CountryCode, Country>
            {
                {CountryCode.AD, Country.Andorra},
                {CountryCode.AE, Country.UnitedArabEmirates},
                {CountryCode.AF, Country.Afghanistan},
                {CountryCode.AG, Country.AntiguaAndBarbuda},
                {CountryCode.AI, Country.Anguilla},
                {CountryCode.AM, Country.Armenia},
                {CountryCode.AO, Country.Angola},
                {CountryCode.AQ, Country.Antarctica},
                {CountryCode.AR, Country.Argentina},
                {CountryCode.AS, Country.AmericanSamoa},
                {CountryCode.AT, Country.Austria},
                {CountryCode.AU, Country.Australia},
                {CountryCode.AW, Country.Aruba},
                {CountryCode.AX, Country.AlandIslands},
                {CountryCode.AZ, Country.Azerbaijan},
                {CountryCode.BA, Country.BosniaAndHerzegovina},
                {CountryCode.BB, Country.Barbados},
                {CountryCode.BD, Country.Bangladesh},
                {CountryCode.BE, Country.Belgium},
                {CountryCode.BF, Country.BurkinaFaso},
                {CountryCode.BG, Country.Bulgaria},
                {CountryCode.BH, Country.Bahrain},
                {CountryCode.BI, Country.Burundi},
                {CountryCode.BJ, Country.Benin},
                {CountryCode.BL, Country.SaintBarts},
                {CountryCode.BM, Country.Bermuda},
                {CountryCode.BN, Country.Brunei},
                {CountryCode.BO, Country.Bolivia},
                {CountryCode.BQ, Country.Bonaire},
                {CountryCode.BR, Country.Brazil},
                {CountryCode.BS, Country.Bahamas},
                {CountryCode.BT, Country.Bhutan},
                {CountryCode.BV, Country.BouvetIsland},
                {CountryCode.BW, Country.Botswana},
                {CountryCode.BY, Country.Belarus},
                {CountryCode.BZ, Country.Belize},
                {CountryCode.CA, Country.Canada},
                {CountryCode.CC, Country.CocosIslands},
                {CountryCode.CD, Country.CongoKinshasa},
                {CountryCode.CF, Country.CentralAfrican},
                {CountryCode.CG, Country.CongoBrazzaville},
                {CountryCode.CN, Country.China},
                {CountryCode.CH, Country.Switzerland},
                {CountryCode.CI, Country.CotedIvoire},
                {CountryCode.CK, Country.CookIslands},
                {CountryCode.CL, Country.Chile},
                {CountryCode.CM, Country.Cameroun},
                {CountryCode.CO, Country.Colombia},
                {CountryCode.CR, Country.CostaRica},
                {CountryCode.CU, Country.Cuba},
                {CountryCode.CV, Country.CapeVerde},
                {CountryCode.CW, Country.Curaçao},
                {CountryCode.CX, Country.ChristmasIsland},
                {CountryCode.CY, Country.Cyprus},
                {CountryCode.CZ, Country.Czechia},
                {CountryCode.DE, Country.Germany},
                {CountryCode.DK, Country.Denmark},
                {CountryCode.DM, Country.Dominica},
                {CountryCode.DO, Country.Dominican},
                {CountryCode.DZ, Country.Algeria},
                {CountryCode.EC, Country.Ecuador},
                {CountryCode.EE, Country.Estonia},
                {CountryCode.EG, Country.Egypt},
                {CountryCode.EH, Country.WesternSahara},
                {CountryCode.ER, Country.Eritrea},
                {CountryCode.ES, Country.Spain},
                {CountryCode.ET, Country.Ethiopia},
                {CountryCode.FI, Country.Finland},
                {CountryCode.FJ, Country.Fiji},
                {CountryCode.FK, Country.FalklandIslands},
                {CountryCode.FM, Country.Micronesia},
                {CountryCode.FO, Country.Faroe},
                {CountryCode.FR, Country.France},
                {CountryCode.GB, Country.UnitedKingdom},
                {CountryCode.GD, Country.Grenada},
                {CountryCode.GE, Country.Georgia},
                {CountryCode.GF, Country.Guiana},
                {CountryCode.GH, Country.Ghana},
                {CountryCode.GI, Country.Georgia},
                {CountryCode.GM, Country.Gambia},
                {CountryCode.GN, Country.Guinea},
                {CountryCode.GP, Country.Guadeloupe},
                {CountryCode.GQ, Country.EquatorialGuinea},
                {CountryCode.GR, Country.Greece},
                {CountryCode.GS, Country.SGSSI},
                {CountryCode.GT, Country.Guatemala},
                {CountryCode.GU, Country.Guam},
                {CountryCode.GW, Country.GuineaBissau},
                {CountryCode.GY, Country.Guyana},
                {CountryCode.HK, Country.HongKong},
                {CountryCode.HM, Country.HIMI},
                {CountryCode.HN, Country.Honduras},
                {CountryCode.HR, Country.Croatia},
                {CountryCode.HT, Country.Haiti},
                {CountryCode.HU, Country.Hungary},
                {CountryCode.ID, Country.Indonesia},
                {CountryCode.IL, Country.Israel},
                {CountryCode.IM, Country.Mann},
                {CountryCode.IN, Country.India},
                {CountryCode.IO, Country.BritishIndianOceanTerritory},
                {CountryCode.IQ, Country.Iraq},
                {CountryCode.IR, Country.Iran},
                {CountryCode.IS, Country.Iceland},
                {CountryCode.IT, Country.Italy},
                {CountryCode.JE, Country.Jersey},
                {CountryCode.JM, Country.Jamaica},
                {CountryCode.JO, Country.Jordan},
                {CountryCode.JP, Country.Japan},
                {CountryCode.KE, Country.Kenya},
                {CountryCode.KG, Country.Kyrgyzstan},
                {CountryCode.KH, Country.Cambodia},
                {CountryCode.KI, Country.Kiribati},
                {CountryCode.KM, Country.Comoros},
                {CountryCode.KN, Country.SaintKittsAndNevis},
                {CountryCode.KP, Country.NorthKorea},
                {CountryCode.KR, Country.SouthKorea},
                {CountryCode.KW, Country.Kuwait},
                {CountryCode.KY, Country.CaymanIslands},
                {CountryCode.KZ, Country.Kazakhstan},
                {CountryCode.LA, Country.LaoPDR},
                {CountryCode.LB, Country.Lebanon},
                {CountryCode.LC, Country.SaintLucia},
                {CountryCode.LI, Country.Liechtenstein},
                {CountryCode.LK, Country.SriLanka},
                {CountryCode.LR, Country.Liberia},
                {CountryCode.LS, Country.Lesotho},
                {CountryCode.LT, Country.Lithuania},
                {CountryCode.LU, Country.Luxembourg},
                {CountryCode.LV, Country.Latvia},
                {CountryCode.LY, Country.Libya},
                {CountryCode.MA, Country.Morocco},
                {CountryCode.MC, Country.Monaco},
                {CountryCode.MD, Country.Moldova},
                {CountryCode.ME, Country.Montenegro},
                {CountryCode.MF, Country.SaintMartinFrenchPart},
                {CountryCode.MG, Country.Madagascar},
                {CountryCode.MH, Country.MarshallIslands},
                {CountryCode.MK, Country.Macedonia},
                {CountryCode.ML, Country.Mali},
                {CountryCode.MM, Country.Myanmar},
                {CountryCode.MN, Country.Mongolia},
                {CountryCode.MP, Country.NorthernMarianaIslands},
                {CountryCode.MQ, Country.Martinique},
                {CountryCode.MR, Country.Mauritania},
                {CountryCode.MS, Country.Montserrat},
                {CountryCode.MT, Country.Malta},
                {CountryCode.MU, Country.Mauritius},
                {CountryCode.MV, Country.Maldives},
                {CountryCode.MW, Country.Malawi},
                {CountryCode.MO, Country.Macao},
                {CountryCode.MY, Country.Malaysia},
                {CountryCode.MZ, Country.Mozambique},
                {CountryCode.NA, Country.Namibia},
                {CountryCode.NC, Country.NewCaledonia},
                {CountryCode.NE, Country.Niger},
                {CountryCode.NG, Country.Nigeria},
                {CountryCode.NF, Country.NorfolkIsland},
                {CountryCode.NI, Country.Nicaragua},
                {CountryCode.NL, Country.Netherlands},
                {CountryCode.NO, Country.Norway},
                {CountryCode.NP, Country.Nepal},
                {CountryCode.NR, Country.Nauru},
                {CountryCode.NU, Country.Niue},
                {CountryCode.NZ, Country.NewZealand},
                {CountryCode.OM, Country.Oman},
                {CountryCode.PA, Country.Panama},
                {CountryCode.PE, Country.Peru},
                {CountryCode.PF, Country.Polynesia},
                {CountryCode.PG, Country.PapuaNewGuinea},
                {CountryCode.PH, Country.Philippines},
                {CountryCode.PK, Country.Pakistan},
                {CountryCode.PL, Country.Poland},
                {CountryCode.PM, Country.SaintPierreAndMiquelon},
                {CountryCode.PN, Country.Pitcairn},
                {CountryCode.PR, Country.PuertoRico},
                {CountryCode.PS, Country.Palestine},
                {CountryCode.PT, Country.Portugal},
                {CountryCode.PW, Country.Palau},
                {CountryCode.PY, Country.Paraguay},
                {CountryCode.QA, Country.Qatar},
                {CountryCode.RE, Country.Réunion},
                {CountryCode.RO, Country.Romania},
                {CountryCode.RS, Country.Serbia},
                {CountryCode.RU, Country.Russia},
                {CountryCode.RW, Country.Rwanda},
                {CountryCode.SA, Country.SaudiArabia},
                {CountryCode.SB, Country.SolomonIslands},
                {CountryCode.SC, Country.Seychelles},
                {CountryCode.SD, Country.Sudan},
                {CountryCode.SE, Country.Sweden},
                {CountryCode.SG, Country.Singapore},
                {CountryCode.SH, Country.SaintHelena},
                {CountryCode.SI, Country.Slovenia},
                {CountryCode.SJ, Country.SvalbardAndJanMayen},
                {CountryCode.SK, Country.Slovakia},
                {CountryCode.SL, Country.SierraLeone},
                {CountryCode.SM, Country.SanMarino},
                {CountryCode.SN, Country.Senegal},
                {CountryCode.SO, Country.Somalia},
                {CountryCode.SR, Country.Suriname},
                {CountryCode.SS, Country.SouthSudan},
                {CountryCode.ST, Country.SaoTomeAndPrincipe},
                {CountryCode.SV, Country.ElSalvador},
                {CountryCode.SX, Country.SintMaartenDutchPart},
                {CountryCode.SY, Country.Syrian},
                {CountryCode.SZ, Country.Swaziland},
                {CountryCode.TC, Country.TurksAndCaicosIslands},
                {CountryCode.TD, Country.Chad},
                {CountryCode.TF, Country.FrenchSouthernTerritories},
                {CountryCode.TG, Country.Togo},
                {CountryCode.TH, Country.Thailand},
                {CountryCode.TJ, Country.Tajikistan},
                {CountryCode.TK, Country.Tokelau},
                {CountryCode.TL, Country.EastTimor},
                {CountryCode.TM, Country.Turkmenistan},
                {CountryCode.TN, Country.Tunisia},
                {CountryCode.TO, Country.Tonga},
                {CountryCode.TR, Country.Turkey},
                {CountryCode.TT, Country.TrinidadAndTobago},
                {CountryCode.TV, Country.Tuvalu},
                {CountryCode.TW, Country.Taiwan},
                {CountryCode.TZ, Country.Tanzania},
                {CountryCode.UA, Country.Ukraine},
                {CountryCode.UG, Country.Uganda},
                {CountryCode.UM, Country.UnitedStatesMinorOutlyingIslands},
                {CountryCode.US, Country.UnitedStates},
                {CountryCode.UY, Country.Uruguay},
                {CountryCode.VA, Country.HolySee},
                {CountryCode.VC, Country.StVAndG},
                {CountryCode.VE, Country.Venezuela},
                {CountryCode.VG, Country.VirginIslandsBritish},
                {CountryCode.VI, Country.VirginIslandsUS},
                {CountryCode.VN, Country.VietNam},
                {CountryCode.VU, Country.Vanuatu},
                {CountryCode.WF, Country.WallisAndFutuna},
                {CountryCode.WS, Country.Samoa},
                {CountryCode.YE, Country.Yemen},
                {CountryCode.YT, Country.Mayotte},
                {CountryCode.XK, Country.Kosovo},
                {CountryCode.ZA, Country.SouthAfrica},
                {CountryCode.ZM, Country.Zambia},
                {CountryCode.ZW, Country.Zimbabwe},
            };
        }

    }
}