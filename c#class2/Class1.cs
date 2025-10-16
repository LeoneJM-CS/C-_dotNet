//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_class2
//{
//    internal class Class1
//    {
//        static void Main(string[] args)
//        {
//            List<int> nums = new List<int>() { 36, 71, 12, 15, 39, 18, 27, 17, 9, 34 };
//            Console.WriteLine("The list: ");
//            foreach (var val in nums) { Console.Write(val + " "); }
//            Console.WriteLine();

//            var square = nums.Select(x => x * x);
//            Console.WriteLine("Squares: ");
//            foreach(var val in square) { Console.Write(val + " "); }
//            Console.WriteLine();

//            List<int> div5 = nums.FindAll(x => (x % 5) == 0);
//            Console.WriteLine("Div by 5: ");
//            foreach (var val in div5) { Console.WriteLine(val); }
//            Console.WriteLine();
//        }
//    }
//}
