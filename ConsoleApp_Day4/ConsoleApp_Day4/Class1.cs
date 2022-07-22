using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day4
{
     class Distance
    {
        int dist;
        public int _Dist
        {
            get { return dist; }
            set { dist = value; }
        }
        //operator + being overloaded here
        public static Distance operator +(Distance d1,Distance d2)
        {
            Distance temp=new Distance();
            temp.dist=d1.dist+d2._Dist;
            return temp;
        }
      }
    class OperatorOverload
    {
        static void Main()
        {
            Distance D1 = new Distance();
            Distance D2 = new Distance();
            D1._Dist =10;
            D2._Dist =20;
            int x = 5, y = 10, z = 0;
            z=x+y;
            Distance d3 = D1+D2;
            Console.WriteLine("the total distance is:");
        }
    }
}
