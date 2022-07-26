﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class A1
    {
        public int i = 0;
        public void MethodHide(string s)
        {
            Console.WriteLine("Message for, Base class is: {0}",s);
        }

    }
    class B1: A1
    {
        new int i;  //this i is hidden from the parent or base class
        public B1(int a,int b)
        {
            base.i=a; //i in A1 class
            i=b; //i in B1 class

        }
        public new void MethodHide(string str)
        {
            Console.WriteLine("Message from Child class{0}",str);
        }

        public void Show()
        {
            Console.WriteLine("i in base class A1 " + " "+ base.i);
            Console.WriteLine("i in base class B1 " + " "+ i);
        }
    }
     class HidingEg
    {
        static void Main()
        {
            B1 bobj=new B1(2, 3);
            bobj.MethodHide("Hi B1");
            bobj.Show();
            Console.Read();
        }
    }
}
