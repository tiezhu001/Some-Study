using System.Collections.Generic;

namespace LINQ.LinqDay01.JoinUse
{
    public class City
    {
        public string CityName { get; set; }
        public int CityId { get; set; }

        public static List<City> GetCitieList()
        {
            return new List<City>() { new City() { CityName = "郑州", CityId = 1 }, new City() { CityName = "开封", CityId = 2 } };
        }
    }
}