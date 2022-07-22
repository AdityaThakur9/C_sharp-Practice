using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Project2
{
    class Project2Program
    {
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            emp.Empname="Mohit";
            Console.WriteLine(emp.Empname);
            emp.Accept();
            emp.display();
            Console.Read();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.Accept();
            employee.display();
            employee.Empname="Shinde";
            Console.Read();
        }
    }
}
