using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class Program
    {
        public static void Swap(int num1, int num2)
        {
            num1=num1+num2;
            num2 = num1-num2;
            num1=num1-num2;
            Console.WriteLine("After swap the first number is: "+num1+"and second number is:"+num2);
        }
        public static void Swap(char c1,char c2)
        {
            char temp = ' ';
            temp=c1;
            c1=c2;
            c2=temp;
            Console.WriteLine("After swap the first char is: "+c1+"and second char is:"+c2);

        }

        public int Add(int x,int y)
        {
            return x+y;
        }
        public int Add(int x, int y,int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Swap(5, 15);
            Swap('a', 'b');
            Program p = new Program();
            int x= p.Add(20, 30);
            Console.WriteLine(x);
            Console.WriteLine(p.Add(30, 50, 20));
            Console.Read();
        }
    }
}
