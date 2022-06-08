using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create class Triangle , calculate perimeter and check if triangle is isosceles
Acceptance criteria
Get all input values from Console
If input values are not double numbers greater than 0 return error message "Incorrect
format"
Add to Triangle class next properties:
double FirstSide, double SecondSide, double ThirdSide,
Add read-only properties:
double Perimeter which should be calculated as a sum of all sides;
bool IsIsosceles which should be true is all sides of triangle are equal
*/

namespace Practice_1
{
    class Triangle
    {
        double side1;
        double side2;
        double side3;        
        public double init_side1
        {
            get 
            {                   
                return side1; 
            }
            set 
            {   
                if (side1 > 0)
                side1 = value; else 
                {
                    Console.WriteLine("Incorrect format!");
                    Console.ReadLine();
                }
            }
        }
        public double init_side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (side2 > 0)
                    side2 = value;
                else
                {
                    Console.WriteLine("Incorrect format!");
                    Console.ReadLine();
                }
            }
        }
        public double init_side3
        {
            get
            {
                return side3;
            }
            set
            {
                if (side3 > 0)
                    side3 = value;
                else
                {
                    Console.WriteLine("Incorrect format!");
                    Console.ReadLine();
                }
            }
        }
        public double perimeter { get { return perimeter; } }

        public bool isisosceles { get { return isisosceles; } }
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1; 
            this.side2 = side2; 
            this.side3 = side3;            
        }

        public  double Perimeter(bool isisosceles)
        {
            if (((side1 == side2) &&(side1 != side3) && (side2 != side3)) || ((side2 == side3) && (side1 != side3) && (side1 != side2)) || ((side3 == side1) && (side3 != side2) && (side1 != side2)))
                    {
                        Console.WriteLine("The triangle is isosceles");
                    }
            if ((side1 == side2) && (side2 == side3) && (side3 == side1)) isisosceles = true;
            if (isisosceles)
                    {                        
                        Console.WriteLine("The triangle is equilateral");
                    }
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }             
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());
            bool isisosceles = false;

            Triangle triangle = new Triangle(side1, side2, side3);
            
            Console.WriteLine(triangle.Perimeter(isisosceles));
            Console.ReadLine();
        }
    }
}
