using System.Collections.Generic;
using System.Linq;
using System;

namespace LINQ.LinqDay01.JoinUse
{
    public class JoinDemo
    {
        #region Data

        class Product
        {
            public string Name { get; set; }
            public int CategoryID { get; set; }
        }

        class Category
        {
            public string CategoryName { get; set; }
            public int ID { get; set; }
        }

        // Specify the first data source.
        List<Category> categories = new List<Category>()
       {
           new Category {CategoryName="Beverages", ID=001},
           new Category {CategoryName="Condiments", ID=002},
           new Category {CategoryName="Vegetables", ID=003},
           new Category {CategoryName="Grains", ID=004},
           new Category {CategoryName="Fruit", ID=005}
       };

        // Specify the second data source.
        List<Product> products = new List<Product>()
      {
         new Product {Name="Cola",  CategoryID=001},
         new Product {Name="Tea",  CategoryID=001},
         new Product {Name="Mustard", CategoryID=002},
         new Product {Name="Pickles", CategoryID=002},
         new Product {Name="Carrots", CategoryID=003},
         new Product {Name="Bok Choy", CategoryID=003},
         new Product {Name="Peaches", CategoryID=005},
         new Product {Name="Melons", CategoryID=005},
       };
        #endregion

        // 内部链接
        public void InnerJoin()
        {
            var InnerJoinQuery = from category in categories
                                 join product in products
                                 on category.ID equals product.CategoryID
                                 select new { CategoryID = category.ID, ProductName = product.Name ,CategoryName=category.CategoryName};

            foreach (var item in InnerJoinQuery)
            {
                Console.WriteLine("{0},{1},{2}", item.CategoryID, item.ProductName,item.CategoryName);
            }

            Console.WriteLine("InnerJoin: {0} items in 1 group.", InnerJoinQuery.Count());
            Console.WriteLine(System.Environment.NewLine);
        }

        // 分组链接
        public void GroupJoin()
        {
            // This is a demonstration query to show the output
            // of a "raw" group join. A more typical group join
            // is shown in the GroupInnerJoin method.
            var groupJoinQuery =
               from category in categories
               join prod in products on category.ID equals prod.CategoryID into prodGroup
               select prodGroup;

            // Store the count of total items (for demonstration only).
            int totalItems = 0;

            Console.WriteLine("Simple GroupJoin:");

            // A nested foreach statement is required to access group items.
            foreach (var prodGrouping in groupJoinQuery)
            {
                Console.WriteLine("Group:");
                foreach (var item in prodGrouping)
                {
                    totalItems++;
                    Console.WriteLine("   {0,-10}{1}", item.Name, item.CategoryID);
                }
            }
            Console.WriteLine("Unshaped GroupJoin: {0} items in {1} unnamed groups", totalItems, groupJoinQuery.Count());
            Console.WriteLine(System.Environment.NewLine);
        }

        public void GroupInnerJoin()
        {
            var GroupInnerJoinQuery = from category in categories
                                      join product in products
                                      on category.ID equals product.CategoryID into groupResult
                                      select new { Category = category.CategoryName, Product = from result in groupResult orderby result.Name descending select result };

            int totalItems = 0;
            foreach (var item in GroupInnerJoinQuery)
            {
                Console.WriteLine(item.Category);
                foreach (var item2 in item.Product)
                {
                    totalItems++;
                    Console.WriteLine( "{0,-10}{1}",item2.Name,item2.CategoryID);
                }
            }

             Console.WriteLine("GroupInnerJoin: {0} items in {1} named groups", totalItems, GroupInnerJoinQuery.Count());
             Console.WriteLine(System.Environment.NewLine);
        }

    }
}