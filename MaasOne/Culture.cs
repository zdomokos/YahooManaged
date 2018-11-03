// ******************************************************************************
// ** 
// **  MaasOne WebServices
// **  Written by Marius Häusler 2012
// **  It would be pleasant, if you contact me when you are using this code.
// **  Contact: YahooFinanceManaged@gmail.com
// **  Project Home: http://code.google.com/p/yahoo-finance-managed/
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius Häusler
// **  
// **  Licensed under the Apache License, Version 2.0 (the "License");
// **  you may not use this file except in compliance with the License.
// **  You may obtain a copy of the License at
// **  
// **    http://www.apache.org/licenses/LICENSE-2.0
// **  
// **  Unless required by applicable law or agreed to in writing, software
// **  distributed under the License is distributed on an "AS IS" BASIS,
// **  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// **  See the License for the specific language governing permissions and
// **  limitations under the License.
// ** 
// ******************************************************************************

namespace MaasOne
{
    public class Culture : System.Globalization.CultureInfo
    {

        private Language mLanguage = Language.en;

        private Country mCountry = Country.US;
        public Language Language => mLanguage;

	    public Country Country => mCountry;

	    public Culture(Language lang, Country cnt)
            : base(lang.ToString().Replace("no", "nn").Replace("tzh", "zh") + "-" + cnt.ToString().Replace("CT", "ES").Replace("UK", "GB"))
        {
            mLanguage = lang;
            mCountry = cnt;
        }

        public override object Clone()
        {
            return new Culture(this.Language, this.Country);
        }
        public Culture CloneStrict()
        {
            return (Culture)this.Clone();
        }
        public override string ToString()
        {
            return this.DisplayName;
        }





        public abstract class DefaultCultures
        {

            private static Culture[] mItems = new Culture[45];
            internal DefaultCultures()
            {
            }

            //New Culture(Language.en, Country.ID), _
            //New Culture(Language.tl, Country.PH), _
            static DefaultCultures()
            {
                mItems[0] = new Culture(Language.es, Country.AR);
                mItems[1] = new Culture(Language.de, Country.AT);
                mItems[2] = new Culture(Language.en, Country.AU);
                mItems[3] = new Culture(Language.pt, Country.BR);
                mItems[4] = new Culture(Language.en, Country.CA);
                mItems[5] = new Culture(Language.fr, Country.CA);
                mItems[6] = new Culture(Language.ca, Country.CT);
                mItems[7] = new Culture(Language.es, Country.CL);
                mItems[8] = new Culture(Language.es, Country.CO);
                mItems[9] = new Culture(Language.cs, Country.CZ);
                mItems[10] = new Culture(Language.da, Country.DK);
                mItems[11] = new Culture(Language.fi, Country.FI);
                mItems[12] = new Culture(Language.fr, Country.FR);
                mItems[13] = new Culture(Language.de, Country.DE);
                mItems[14] = new Culture(Language.tzh, Country.HK);
                mItems[15] = new Culture(Language.hu, Country.HU);
                mItems[16] = new Culture(Language.id, Country.ID);
                mItems[17] = new Culture(Language.en, Country.IN);
                mItems[18] = new Culture(Language.he, Country.IL);
                mItems[19] = new Culture(Language.it, Country.IT);
                mItems[20] = new Culture(Language.ja, Country.JP);
                mItems[21] = new Culture(Language.ko, Country.KR);
                mItems[22] = new Culture(Language.en, Country.MY);
                mItems[23] = new Culture(Language.ms, Country.MY);
                mItems[24] = new Culture(Language.es, Country.MX);
                mItems[25] = new Culture(Language.nl, Country.NL);
                mItems[26] = new Culture(Language.no, Country.NO);
                mItems[27] = new Culture(Language.en, Country.NZ);
                mItems[28] = new Culture(Language.es, Country.PE);
                mItems[29] = new Culture(Language.en, Country.PH);
                mItems[30] = new Culture(Language.ro, Country.RO);
                mItems[31] = new Culture(Language.ru, Country.RU);
                mItems[32] = new Culture(Language.en, Country.SG);
                mItems[33] = new Culture(Language.es, Country.ES);
                mItems[34] = new Culture(Language.fr, Country.CH);
                mItems[35] = new Culture(Language.de, Country.CH);
                mItems[36] = new Culture(Language.it, Country.CH);
                mItems[37] = new Culture(Language.th, Country.TH);
                mItems[38] = new Culture(Language.tr, Country.TR);
                mItems[39] = new Culture(Language.tzh, Country.TW);
                mItems[40] = new Culture(Language.en, Country.UK);
                mItems[41] = new Culture(Language.en, Country.US);
                mItems[42] = new Culture(Language.es, Country.US);
                mItems[43] = new Culture(Language.es, Country.VE);
                mItems[44] = new Culture(Language.vi, Country.VN);
            }

            public static Culture[] Items => mItems;

	        public static Culture Argentina => mItems[0];

	        public static Culture Austria => mItems[1];

	        public static Culture Australia => mItems[2];

	        public static Culture Brazil => mItems[3];

	        public static Culture Canada_English => mItems[4];

	        public static Culture Canada_French => mItems[5];

	        public static Culture Catalan => mItems[6];

	        public static Culture Chile => mItems[7];

	        public static Culture Columbia => mItems[8];

	        public static Culture CzechRepublic => mItems[9];

	        public static Culture Denmark => mItems[10];

	        public static Culture Finland => mItems[11];

	        public static Culture France => mItems[12];

	        public static Culture Germany => mItems[13];

	        public static Culture HongKong => mItems[14];

	        public static Culture Hungary => mItems[15];

	        public static Culture Indonesia => mItems[16];

	        public static Culture India => mItems[17];

	        public static Culture Israel => mItems[18];

	        public static Culture Italy => mItems[19];

	        public static Culture Japan => mItems[20];

	        public static Culture Korea => mItems[21];

	        public static Culture Malaysia_English => mItems[22];

	        public static Culture Malaysia_Malaysian => mItems[23];

	        public static Culture Mexico => mItems[24];

	        public static Culture Netherlands => mItems[25];

	        public static Culture Norway => mItems[26];

	        public static Culture NewZealand => mItems[27];

	        public static Culture Peru => mItems[28];

	        public static Culture Philippines_English => mItems[29];

	        public static Culture Romania => mItems[30];

	        public static Culture Russia => mItems[31];

	        public static Culture Singapore => mItems[32];

	        public static Culture Spain => mItems[33];

	        public static Culture Switzerland_French => mItems[34];

	        public static Culture Switzerland_German => mItems[35];

	        public static Culture Switzerland_Italian => mItems[36];

	        public static Culture Thailand => mItems[37];

	        public static Culture Turkey => mItems[38];

	        public static Culture Taiwan => mItems[39];

	        public static Culture UnitedKingdom => mItems[40];

	        public static Culture UnitedStates_English => mItems[41];

	        public static Culture UnitedStates_Spanish => mItems[42];

	        public static Culture Venezuela => mItems[43];

	        public static Culture Vietnam => mItems[44];
        }
    }
}
