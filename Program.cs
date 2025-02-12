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
        }
    }
}
