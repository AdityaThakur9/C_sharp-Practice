using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
    class shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f*R*R;
        }

        public virtual float Circumference()
        {
            return 2* 3.14f * R;
        }
    }
    class Rectangle: shape
    {
        public void GetLB()
        {
            Console.Write("Enter length: ");
            L= float.Parse(Console.ReadLine());
            Console.Write("Enter breadth: ");
            B= float.Parse(Console.ReadLine()); 

        }
        public override float Area()
        {
            return L*B;
        }
        public override float Circumference()
        {
            return 2*(L+B);
        }
    }
    class Circle: shape
    {
        public void GetRadius()
        {
            Console.Write("Enter radius: ");
            R= float.Parse(Console.ReadLine());
        }
    }
    class OverrideEg
    {
        static void Main()
        {
            Rectangle R= new Rectangle();
            R.GetLB();
            Console.WriteLine("Area of rectangle is : {0}",R.Area());
            Console.WriteLine("Circumference of rectangle is: {0},",R.Circumference());
            Console.WriteLine("=======================================");
            Circle C = new Circle();
            C.GetRadius();
            Console.WriteLine("Area of Circle:{0}", C.Area());
            Console.WriteLine("Circumference of circle:{0}", C.Circumference());
        }
    }
}
