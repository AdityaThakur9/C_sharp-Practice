using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        int Empid;
        public string Empname;
        DateTime DOJ;
        float salary;

        public void Accept()
        {
            Console.WriteLine("Enter the Employee nID, name, DOJ, and salary: ");
            Empid=Convert.ToInt32(Console.ReadLine());
            Empname=Console.ReadLine();
            DOJ=Convert.ToDateTime(Console.ReadLine());
            salary=Convert.ToSingle(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine($"EmpID: {Empid},Name:{Empname},DOJ: {DOJ},Salary: {salary}");
        }
        static void Main(string[] args)
        {

        }
    }
}
