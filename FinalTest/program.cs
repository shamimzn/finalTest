using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
         
            Human[] humans = new Human[2] { new Adult("Shamim","Zohourian"), new Child("Ane","Bor")};
            foreach (Human h in humans)
            {
                h.print();
            
            }



        }
    }
}
