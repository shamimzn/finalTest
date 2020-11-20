using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Child:Human
    {
        private string _FirstName;
        private string _LastName;

       public Child(string first, string last)
        {
            _FirstName = first;
            _LastName = last;

        }
        public string FirstName   
        {
            get { return _FirstName; }   
            set { _FirstName = value; } 
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public override void print()
        {
            Console.WriteLine(FirstName + " " + LastName);

            base.print();
        }

    }
}
