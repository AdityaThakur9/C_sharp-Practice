using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_APP_Day2
{
     class Program
    {
        static void Main(string[] args)
        {
            /*int x = 10;
            SimpleMethod(x);    //call by value
            Console.WriteLine($"The result by call by value method is:{x}");
            SimpleRefMethod(ref x);     //Call by reference
            Console.WriteLine($"The result by call by refernce method is:{x}");
            int total, prod;
            int diff = Calculate(10, 20, out total, out prod);
            Console.Read();*/
            /* int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the operation you want to perform : \n1.Addition. \n2.Subtraction \n3.product \n4.Division: ");
             int Choice = Convert.ToInt32(Console.ReadLine());
             switch (Choice)
             {
                 case 1:
                     {
                         Console.WriteLine("The sum is:{0} ", a + b);
                         break;
                     }
                 case 2:
                     {
                         Console.WriteLine("The difference is:{0} ", a - b);
                         break;
                     }
                 case 3:
                     {
                         Console.WriteLine("The product is:{0} ", a * b);
                         break;
                     }
                 case 4:
                     {
                         Console.WriteLine("The divison is:{0} ", a/ b);
                         break;
                     }
                     default:
                     Console.WriteLine("Not a valid option");
                     break;
             }
             Console.WriteLine("End reached");
             Console.Read();*/
            CheckEven();
            LargestandSmallest();
            FarhtoCelius();
        }

        //program to check if number if odd or even
        public static void CheckEven()
        {
            Console.WriteLine("Enter the number you want to check: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string st = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(a + " is " + st);
            Console.Read();
        }

        // take three numbers to check the largest and the smallest.
        public static void LargestandSmallest()
        {
            Console.WriteLine(" Enter the three numbers to be checked: \n");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int smallest, largest;
            largest = (a > b && b > c) ? a : (b > a && b > c) ? b : c;
            smallest = (a < b && b < c) ?a : (b < a && b < c) ? b : c;
            Console.WriteLine("The largest number is: {0} and the smallest number is {1}", largest, smallest);


        }

        //Convert and display temprature in celsius.
        public static void FarhtoCelius()
        {
            Console.WriteLine("Enter temprature in Fahreinheit: ");
            double fah=Convert.ToDouble(Console.ReadLine());
            double cel = (fah - 32) * 5 / 9;
            Console.WriteLine("Temprature in Celsius is:", cel);
            Console.Read();
        }


        /*//call by value
        public static void SimpleMethod(int j)
        {
            j = 100;
        }

        // Call by Reference
        public static void SimpleRefMethod(ref int j)
        {
             j = 100;
        }

        // Output Parameter method where we use 'out' keyowrd in function argument to tell that its output)
        public static int Calculate(int i, int j, out int sum, out int product)
        {
            sum = i + j;
            product = i* j;
            return j - i;


        }*/
    }
}
