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
        }
    }
}
