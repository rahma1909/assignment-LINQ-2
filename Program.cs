using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static assignment.ListGenerators;
namespace assignment
{
    class stringcomparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.ToLower().CompareTo(y.ToLower());
        }
    }
    class stringcomparereLength : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
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

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            //var res = ProductList.OrderBy(p => p.ProductName, new namecomparer());

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var res = arr.OrderBy(a => a, new stringcomparer());

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var res = ProductList.Where(p=>p.UnitsInStock>0)
            //    .OrderByDescending(p => p.UnitsInStock,new unitsinstockComparer());
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.


            //string[] Arr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

            //var res = Arr.OrderBy(x => x.Length, new stringcomparereLength()).ThenBy(x => x, new stringcomparer());

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res = Arr.OrderBy(a => a.Length, new stringcomparereLength()).ThenBy(a=>a,new stringcomparer());

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = ProductList.OrderByDescending(p => p.Category, new categoryComparer()).ThenByDescending(p => p.UnitPrice, new unitpriceComparer());
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////done before
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];


            //var res = Arr.Where(w=>w.Length>0 && w[1]=='i').Reverse();



            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var res = from p in ProductList
            //          select p.ProductName;


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = words.Select(p => new
            //{
            //    up = p.ToUpper(),
            //    lo = p.ToLower()
            //});


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var res = ProductList.Select(p => new
            //{
            //    category=p.Category,
            //    price=p.UnitPrice
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //indexed select
            //var res = Arr.Select((n,I) => new
            //{
            //    number = n,
            //    inplace = n == I
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            ////query expression
            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select (a, b);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var res = CustomerList.SelectMany(o => o.Orders).Where(p=>p.Total<500.00M);


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List


            //var res = (from p in ProductList
            //           select p.Category).Distinct();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var res = (from p in ProductList
            //           select p.ProductName.ElementAt(0)).Distinct().Union((from c in CustomerList
            //                                                                select c.CustomerName.ElementAt(0)).Distinct());



            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);  
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var res = (from p in ProductList
            //           select p.ProductName.ElementAt(0)).Distinct().Intersect((from c in CustomerList
            //                                                                select c.CustomerName.ElementAt(0)).Distinct());



            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var res = (from p in ProductList
            //           select p.ProductName.ElementAt(0)).Distinct().Except((from c in CustomerList
            //                                                                    select c.CustomerName.ElementAt(0)).Distinct());



            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var res = (from p in ProductList
            //           select p.ProductName.Skip((p.ProductName.Length) - 3))
            //           .Concat(from c in CustomerList
            //                   select c.CustomerName.Skip((c.CustomerName.Length)-3)).SelectMany(x=>x);



            //var res = (from p in ProductList
            //           select p.ProductName.Substring((p.ProductName.Length) - 3))
            //           .Concat(from c in CustomerList
            //                   select c.CustomerName.Substring((c.CustomerName.Length) - 3));

            //foreach (var item in res)
            //{
            //    Console.Write(item);
            //    Console.WriteLine();
            //}
            #endregion



            #endregion


        }
    }
}
