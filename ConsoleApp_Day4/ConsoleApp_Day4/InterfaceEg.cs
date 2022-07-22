using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    interface ICustomer
    {
        void Print();
        int Add(int x, int y);
    }
     interface Icustomer2:ICustomer
    {
        void Display();
    }
    class Customer: Icustomer2,  ICustomer
    {
        public int  Add(int x, int y)
        {
            return x + y;
        }

        public void Display()
        {

        }
        public void Print()
        {
            Console.WriteLine("Icustomer interface Method");
        }
    }
     class InterfaceEg
    {
        static void Main()
        {
            //Customer c = new Customer();
            ICustomer ic = new ICustomer();
            ic.Print();
            Console.Read();
        }
    }
}
