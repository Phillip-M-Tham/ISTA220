using System;

namespace ISTA220Ex01MathematicalFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Part 1
            Console.WriteLine("Part 1, Cicumference and area of a circle");
            Console.WriteLine("Enter an integer for the radius: ");
            string strRadius = Console.ReadLine();
            int intRadius = int.Parse(strRadius);
            double Circumference = 2 * Math.PI * intRadius;
            Console.WriteLine($"The Circumference is {Circumference}");
            double area = Math.PI * intRadius * intRadius;
            Console.WriteLine($"The area is {area}");
            //This is Part 2
            Console.WriteLine("\n Part 2, volume of a hemisphere ");
            Console.WriteLine("Enter an integer for the radius: ");
            string strRadius2 = Console.ReadLine();
            double doubleRadius2 = double.Parse(strRadius2);
            double doubleR3 = doubleRadius2 * doubleRadius2 * doubleRadius2;
            double volume = (2.0/3.0) * Math.PI * doubleR3;
            Console.WriteLine($"The volume is {volume}");
            //This is Part 3
            Console.WriteLine("\n Part 3, area of a triangle (Heron's forumula)");
            Console.WriteLine("Enter Triangle side one");
            string strSide1 = Console.ReadLine();
            double doubleA = double.Parse(strSide1);
            Console.WriteLine("Enter Triangle second side");
            string strSide2 = Console.ReadLine();
            double doubleB = double.Parse(strSide2);
            Console.WriteLine("Enter Triangle third side");
            string strSide3 = Console.ReadLine();
            double doubleC = double.Parse(strSide3);
            double p = (doubleA + doubleB + doubleC) / 2.0;
            double area2 = Math.Sqrt(p*(p - doubleA) * (p - doubleB) * (p - doubleC));
            Console.WriteLine($"The area is {area2}");
            //Part 4
            Console.WriteLine("\n Part 4, solving a quadratic equation");
            Console.WriteLine("Enter Triangle side one");
            string strA = Console.ReadLine();
            double doubleA2 = double.Parse(strA);
            Console.WriteLine("Enter Triangle second side");
            string strB = Console.ReadLine();
            double doubleB2 = double.Parse(strB);
            Console.WriteLine("Enter Triangle third side");
            string strC = Console.ReadLine();
            double doubleC2 = double.Parse(strC);
            double denominator = 2* doubleA2;
            double positive_num = -doubleB2 + Math.Sqrt((doubleB2*doubleB2)-4*doubleA2*doubleC2);
            double negative_num = -doubleB2 - Math.Sqrt((doubleB2*doubleB2) -4*doubleA2*doubleC2);
            Console.WriteLine($"The Positive solution is {positive_num/ denominator}");
            Console.WriteLine($"The negative solution is {negative_num/denominator}");
            //double answer;
        }
    }
}
