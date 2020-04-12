using System.Collections.Generic;

namespace LINQ.LinqDay01.JoinUse
{
    public class Province
    {
        public string ProvinceName { get; set; }
        public string CityName { get; set; }

        public static List<Province> GetProvinceList()
        {
            List<Province> list = new List<Province>() { new Province() { ProvinceName = "河南", CityName = "郑州" }, new Province() { ProvinceName = "浙江", CityName = "杭州" } };
            return list;

        }
    }


}