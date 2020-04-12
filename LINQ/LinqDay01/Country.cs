using System;
using System.Collections.Generic;

namespace LINQ.LinqDay01
{
    public class Country
    {
        public string CountryName{get;set;}
        public int CountryCode{get;set;}
        // public List<string> CityList{get;set;}
        public List<CountryCity> Citys{get;set;}

        

    }
}