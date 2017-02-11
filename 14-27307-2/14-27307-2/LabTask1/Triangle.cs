using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    class Triangle
    {
        public int x;
        public int y;
        public int z;
       public void input()
       {
           Console.WriteLine("Enter three side of a Tringle");
           x = Convert.ToInt32(Console.ReadLine());
           y =  Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
       }
       public void ShowDetails()
       {
           Console.WriteLine("the three side of tringle is "+"\n"+x+"\n"+y+"\n"+z);
       }
        public void TestTriangle()
        {
            if(x==y && y==z)
            {
            Console.WriteLine(" equilateral");
            }
             else if(x==y || y==z || x==z)
            {
                Console.WriteLine(" isosceles");
            }
              else 
            {
            Console.WriteLine(" scalene");
            }
        }
    }
}
