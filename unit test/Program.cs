using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
   
   
        public class Program
        {
            static void Main(string[] args)
            {
                double b;
                double h;

            Console.WriteLine("*** This Program will calculate the area of a right angled triangle ***");

                Console.WriteLine("Enter the length of the base: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the triangle: ");
                h = Convert.ToDouble(Console.ReadLine());

                double area = Program.calculateArea(b, h);
                Console.WriteLine(area);
                Console.ReadLine();
            }

            public static double calculateArea(double b, double h)
            {
            
                return 0.5 * b * h;
            }
        }
   
}
