using System.Data.Common;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static assignment.ListGenerators;
namespace assignment
{


    internal class Program
    {

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.

            //var res = ProductList.Where(p=>p.UnitsInStock==0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var res = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res = Arr.Where((a, I) => a.Length < I);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 

            //var res = ProductList.FirstOrDefault();
            //Console.WriteLine(res);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault(new Product
            //{
            //    ProductName="there is no products matched"
            //});

            //Console.WriteLine(res);

            #endregion

            #region 3.Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var res = Arr.Where(n => n > 5).ElementAt(3);
            //Console.WriteLine(res);//7

            #endregion


            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Where(n => n % 2 == 1).Count();
            //Console.WriteLine(res);//5

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var res = CustomerList.Where(c => c.Orders.Count() > 0).Select(c=>new
            //{
            //    customer = c,
            //    ordercount=c.Orders.Count()
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has

            //var res = ProductList.Select(c => new
            //{
            //    cat = c.Category,
            //    numOfproducts = c.ProductID
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Sum();
            //Console.WriteLine(res);
            #endregion


            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var total = arr.Sum(x => x.Length
            //);
            //Console.WriteLine(total);
            #endregion


            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //fluent
            //var res = arr.Where(x => x.Length > 0).OrderBy(a => a.Length).FirstOrDefault()?.Length;
            //Console.WriteLine(res);

            //query

            //var res = (from w in arr
            //           where w.Length > 0 
            //           orderby w.Length ascending
            //           select w.Length).FirstOrDefault();

            //Console.WriteLine(res);
            #endregion


            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] arr = File.ReadAllLines("dictionary_english.txt");

            //var res = arr.Where(a => a.Length > 0).OrderByDescending(a => a.Length)?.FirstOrDefault().Length;
            //Console.WriteLine(res);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] arr = File.ReadAllLines("dictionary_english.txt");

            //var res = arr.Average(a=>a.Length);
            //Console.WriteLine(res);
            #endregion

            #region 9. Get the total units in stock for each product category.
            //var res = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(g=>g.Category)
            //    .Select(c => new
            //    {
            //        category = c.Key,
            //        numofunitsinstock =  c.Sum(x=>x.UnitsInStock)
            //    });

            //query expression
            //var res = from p in ProductList
            //          where p.UnitsInStock > 0
            //          group p by p.Category
            //         into w
            //          select new
            //          {
            //              cat = w.Key,
            //              numofunitsinstock = w.Sum(x => x.UnitsInStock)
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var res = ProductList.GroupBy(g => g.Category).Select(g => new
            //{
            //   category= g.Key,
            //   cheapestprice=g.Min(x=>x.UnitPrice)
            //});


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var res = from p in ProductList
            //          let price = p.UnitPrice
            //          group p by p.Category
            //          into g
            //          select new
            //          {
            //              cat = g.Key,
            //              cheapestprice = g.Min(p => p.UnitPrice)
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var res = ProductList.GroupBy(p => p.Category).Select(c =>new
            //{

            //    category=c.Key,
            //    expeice=c.Max(x=>x.UnitPrice)
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var res = ProductList.GroupBy(p => p.Category).Select(x => new
            //{
            //    category=x.Key,
            //    productswithexprice=x.MaxBy(p=>p.UnitPrice)

            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 14. Get the average price of each category's products.
            //var res = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    cat=c.Key,
            //    avgPrice=c.Average(p=>p.UnitPrice)
            //});


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion



        }
    }
}
