using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class2
{
    public partial class Test1 // Partial Class
    {
        public string fullName()
        {
            return firstName + " " + lastName;
        }
        public partial void WelcomeMessage(string msg) //Partial Method
        {
            Console.WriteLine(msg);
            Welcome2();
        }
        public void Welcome2()
        {
            Console.WriteLine("General Kenobi!");
        }
    }
}
