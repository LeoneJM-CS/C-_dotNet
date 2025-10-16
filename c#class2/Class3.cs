using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class2
{
    public partial class Test1 // Partial class
    {
        private string firstName;
        private string lastName;

        public string FirstName 
        {
            get { return firstName; } 
            set { firstName = value; } 
        }

        public string LastName 
        { 
            get { return lastName; } 
            set { lastName = value; } 
        }
        public partial void WelcomeMessage(string message); // Partial Method
    }
}
