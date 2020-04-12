using System;
using System.Linq;
using System.Collections.Generic;
using LINQ.LinqDay01;
using LINQ.LinqDay01.JoinUse;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  01-Day  group by

            // City luoshanji = new City() { CityName = "洛杉矶", PepleCount = 5000000 };
            // City mengfeisi = new City() { CityName = "孟菲斯", PepleCount = 500000 };
            // City niuyue = new City() { CityName = "纽约", PepleCount = 10000000 };
            // City danfo = new City() { CityName = "丹佛", PepleCount = 400000 };

            // City Bj = new City() { CityName = "北京", PepleCount = 20000000 };
            // City Sh = new City() { CityName = "上海", PepleCount = 15000000 };
            // City gz = new City() { CityName = "广州", PepleCount = 10000000 };
            // City Zz = new City() { CityName = "郑州", PepleCount = 4000000 };

            // Country usa = new Country() { CountryName = "USA", CountryCode = 2, Citys = new List<City>() { luoshanji, mengfeisi, niuyue, danfo } };
            // Country china = new Country() { CountryName = "CHINA", CountryCode = 1, Citys = new List<City>() { Bj, Sh, gz, Zz } };
            // List<Country> countryList = new List<Country>() { usa, china };
            // List<City> cityList = new List<City>() { luoshanji, mengfeisi, niuyue, danfo, Bj, Sh, gz, Zz };

            // var cityQuery = from country in countryList
            //                 from city in country.Citys
            //                 where city.PepleCount > 4500000
            //                 select new { CityName = city.CityName, Count = city.PepleCount, Country = country.CountryName };

            // // foreach (var city in cityQuery)
            // // {
            // //     Console.WriteLine(city.CityName);
            // // }

            // // group 字句
            // var queryCity = from city in cityList
            //                 group city by city.PepleCount > 5000000;


            // // First Group
            // List<City> firstGroupCityList = new List<City>();
            // List<City> secondGroupCityList = new List<City>();
            // foreach (var city in queryCity)
            // {
            //     Console.WriteLine(city.Key);
            //     Console.WriteLine("11111111111111111111");
            //     if (city.Key)
            //     {
            //         foreach (var eachCity in city)
            //         {
            //             firstGroupCityList.Add(eachCity); ;
            //         }
            //     }

            // }
            // foreach (var city in firstGroupCityList)
            // {
            //     Console.WriteLine(city.CityName);
            // }
            // Console.WriteLine("-----------------");
            // // group字句附加查询
            // var queryCitybygroup = from city in cityList
            //                        group city by city.CityName into g
            //                        orderby g.Key descending
            //                        select g;

            // foreach (var eachcityGroup in queryCitybygroup)
            // {
            //     // Console.WriteLine(eachcityGroup.Key);

            //     foreach (var city in eachcityGroup)
            //     {
            //         Console.WriteLine(city.CityName);
            //     }
            // }


            #endregion

            #region 02-Day into 关键字

            // string[] words = { "apples", "olueberries", "oranges", "oananas", "apricots"};
            // var wordGroup1 = from w in words
            //                 group w by w[0] into fruitGroup
            //                 where fruitGroup.Count()>=2
            //                 select new {FirstLetter=fruitGroup.Key,words=fruitGroup.Count()};
            // foreach(var item in wordGroup1){
            //     Console.WriteLine(item);
            // }




            #endregion

            #region 02-Day Join字句
            // List<City> cityList = City.GetCitieList();
            // List<Province> provincesList = Province.GetProvinceList();

            // var innerJoinQuery = from city in cityList
            //                      join province in provincesList
            //                      on city.CityName equals province.CityName
            //                      select new { CityName = city.CityName, ProvinceName = province.ProvinceName };

            // var innerJoinQuery2 = from city in cityList
            //                       join province in provincesList
            //                       on city.CityName equals province.CityName into groupResult
            //                       select new { CityName = city.CityName, Result = groupResult.FirstOrDefault() };
            // foreach (var item in innerJoinQuery)
            // {
            //     Console.WriteLine(string.Format("CityName: {0}, Result: {1}", item.CityName, item.ProvinceName));
            //     // foreach (var item2 in item.Result)
            //     // {
            //     //     Console.WriteLine(item2.ProvinceName);
            //     // }

            // }

            // foreach (var item in innerJoinQuery2)
            // {
            //     Console.WriteLine(string.Format("CityName: {0}, Result: {1}", item.CityName, item.Result));


            // }

            // JoinDemo test = new JoinDemo();
            // test.InnerJoin();

            // test.GroupJoin();

            // test.GroupInnerJoin();

            #endregion

            #region 03-Day Let查询关键字
            // Let关键字让查询出来的元素执行同一个操作，而不用查询出一个元素执行一个操作
            // 比如再一句话中 想查出以AEIOU开头的单词,然后让这些单词变为大写

            string[] strings = { "A penny saved is a penny earned .",
            "The early bird catches the worm.",
            "The pen is mightier than the sword." };

            var query = from p in strings
                        let a = p.Split(",")
                        select a;
            // from word in a
            // where word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
            // select word;


            string stringResult = null;
            foreach (var s in query)
            {
               foreach(var item in s){
                   Console.WriteLine(item);
               }
            }
            Console.WriteLine(stringResult);

            var query2 = from p in strings
                        let b = p.Split(" ")
                        from word in b
                        where word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
                        select word;
            
            foreach(var item in query2){
                Console.WriteLine(item);
            }




            #endregion
        }
    }
}