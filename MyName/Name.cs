using System;

namespace Yossatron.MyName
{
    public class Name
    {
        public string Get(string lang = "e")
        {
            if("e".Equals(lang)){
                return GetEnglish();
            }
            return GetThai();
        }

        private string GetThai()
        {
            return "ยศธร";
        }
        private string GetEnglish()
        {
            return "Yossatron";
        }

    }
}
