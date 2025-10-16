using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class2
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Partial Class");
            Test1 obj = new Test1();
            obj.FirstName = "Joel";
            obj.LastName = "Leone";
            var name = obj.fullName();
            Console.WriteLine(name);
            obj.WelcomeMessage("Hello There");
        }
    }
}
