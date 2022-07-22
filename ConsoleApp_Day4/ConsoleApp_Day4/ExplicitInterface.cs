using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    interface Ifirst
    {
        void Method1();
    }
    interface Isecond
    {
        void Method1();
    }

    class ExplicitInterface : Ifirst, Isecond
    {
         void Ifirst.Method1()      //cannot use access modifier while explicitly implementing
        {
            Console.WriteLine("Ifirst Implementation");
        }
        
        void Isecond.Method1()
        {
            Console.WriteLine("Isecond Implementation");
        }

        public static void Main()
        {
            ExplicitInterface ei= new ExplicitInterface();      //Method1 by typecasting
            ((Ifirst)ei).Method1();
            ((Isecond)ei).Method1();
            Ifirst ifirst = new ExplicitInterface();            // Method2
            Isecond ifsecond = new ExplicitInterface();
            ifirst.Method1();
            ifsecond.Method1();
            Console.ReadLine();
        }
    }
}
