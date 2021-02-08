using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex03_tham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1, Cicumference and area of a circle");
            calcCircleStuff();
            Console.WriteLine("\n Part 2, volume of a hemisphere ");
            calcVolumeHemi();
            Console.WriteLine("\n Part 3, area of a triangle (Heron's forumula)");
            calcHeronFormula();
            Console.WriteLine("\n Part 4, solving a quadratic equation");
            calcQuad();
            //EX1(0);
        }
        private static void calcCircleStuff()
        {
            bool myWire = true;
            try 
            { 
                Console.WriteLine("Enter an integer for the radius: ");
                string strRadius = Console.ReadLine();
                int intRadius = int.Parse(strRadius);
                if(intRadius <= 0)
                {
                    throw new Exception("Your number is out of range");
                }
                double Circumference = 2 * Math.PI * intRadius;
                Console.WriteLine($"The Circumference is {Circumference}");
                double area = Math.PI * intRadius * intRadius;
                Console.WriteLine($"The area is {area}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                myWire = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                myWire = false;
            }
            finally
            {
                Console.WriteLine("okay");
                if (myWire == false)
                {
                    calcCircleStuff();
                }
                
            }
        }

        private static void calcVolumeHemi()
        {
            bool myWire = true;
            try
            { 
                Console.WriteLine("Enter an integer for the radius: ");
                string strRadius2 = Console.ReadLine();
                double doubleRadius2 = double.Parse(strRadius2);
                if(doubleRadius2 <= 0)
                {
                    throw new Exception("Your number is out of range");
                }
                double doubleR3 = doubleRadius2 * doubleRadius2 * doubleRadius2;
                double volume = (2.0 / 3.0) * Math.PI * doubleR3;
                Console.WriteLine($"The volume is {volume}");
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                myWire = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                myWire = false;
            }
            finally
            {
                Console.WriteLine("Okay");
                if (myWire == false)
                {
                    calcVolumeHemi();
                }
            }
        }

        private static void calcHeronFormula()
        {
            bool myWire = true;
            try
            {
                Console.WriteLine("Enter Triangle side one");
                string strSide1 = Console.ReadLine();
                double doubleA = double.Parse(strSide1);
                if(doubleA <= 0)
                {
                    throw new Exception("Your number is out of range");
                }
                Console.WriteLine("Enter Triangle second side");
                string strSide2 = Console.ReadLine();
                double doubleB = double.Parse(strSide2);
                if (doubleB <= 0)
                {
                    throw new Exception("Your number is out of range");
                }
                Console.WriteLine("Enter Triangle third side");
                string strSide3 = Console.ReadLine();
                double doubleC = double.Parse(strSide3);
                if (doubleC <= 0)
                {
                    throw new Exception("Your number is out of range");
                }
                double p = (doubleA + doubleB + doubleC) / 2.0;
                double area2 = Math.Sqrt(p * (p - doubleA) * (p - doubleB) * (p - doubleC));
                Console.WriteLine($"The area is {area2}");
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                myWire = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                myWire = false;
            }
            finally
            {
                Console.WriteLine("okay");
                if(myWire==false)
                {
                    calcHeronFormula();
                }
            }
        }
        private static void calcQuad()
        {
            bool myWire = true;
            try
            {
                Console.WriteLine("Enter Triangle side one");
                string strA = Console.ReadLine();
                double doubleA2 = double.Parse(strA);
                Console.WriteLine("Enter Triangle second side");
                string strB = Console.ReadLine();
                double doubleB2 = double.Parse(strB);
                Console.WriteLine("Enter Triangle third side");
                string strC = Console.ReadLine();
                double doubleC2 = double.Parse(strC);
                double denominator = 2 * doubleA2;
                double positive_num = -doubleB2 + Math.Sqrt((doubleB2 * doubleB2) - 4 * doubleA2 * doubleC2);
                double negative_num = -doubleB2 - Math.Sqrt((doubleB2 * doubleB2) - 4 * doubleA2 * doubleC2);
                Console.WriteLine($"The Positive solution is {positive_num / denominator}");
                Console.WriteLine($"The negative solution is {negative_num / denominator}");
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                myWire = false;
            }
            finally
            {
                Console.WriteLine("Okay");
                if (myWire == false)
                {
                    calcQuad();
                }
            }
        }
        /*private static void EX1(int test)
        {
            //if(int = 0) { 
            try
            {
                if (test == 0)
                {
                    Console.WriteLine("Part 1, circumference and area of a circle.");
                    Console.WriteLine("Enter an integer for the radius: ");
                    double radius;
                    bool p1 = double.TryParse(Console.ReadLine(), out radius);
                    if(p1 == false)
                    {
                        test = 0;
                        throw new FormatException("You must enter a valid number");
                    }
                    if (radius <= 0)
                    {
                        test = 0;
                        throw new Exception("your number is out of range");
                       
                    }
                    double circumference = 2 * (Math.PI * radius);
                    double area = Math.PI * (radius * radius);
                    Console.WriteLine($"The area is { area }");
                    Console.WriteLine($"The circumference is {circumference}");

                    Console.WriteLine("Part 2, volume of a hemisphere. Enter an integer for the radius:");
                    double volume; 
                    bool p2 = double.TryParse(Console.ReadLine(),out volume);
                    if (p2 == false)
                    {
                        test = 1;
                        throw new FormatException("You must enter a valid number");
                    }
                    if (volume <= 0)
                    {
                        test = 1;
                        throw new Exception("your number is out of range");
                       
                    }
                    volume = (Convert.ToDouble(4) / Convert.ToDouble(3) * (Math.PI * (System.Math.Pow(volume, 3)))) / 2;
                    Console.WriteLine($"The volume is { volume }");

                    Console.WriteLine("Part 3, Area of a triangle (Heron's Formula).");
                    Console.WriteLine("Enter an integer for side 1:");
                    double a; 
                    bool p3= double.TryParse(Console.ReadLine(), out a);
                    if(p3 ==false)
                    {
                        test = 2;
                        throw new FormatException("You must enter a valid number");

                    }
                    if (a <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range");
                        
                    }
                    Console.WriteLine("Enter an Integer for side 2:");
                    double b;
                    bool p4= double.TryParse(Console.ReadLine(), out b);
                    if(p4 ==false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (b <= 0)
                    {
                        //we can add a different test number here to start the question here
                        test = 2;
                        throw new Exception("your number is out of range");
                        
                    }
                    Console.WriteLine("Enter an integer for side 3:");
                    double c;
                    bool p5= double.TryParse(Console.ReadLine(),out c);
                    if(p5 == false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (c <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range.");
                       
                    }
                    double p = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
                    double triangleArea = Convert.ToDouble(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))));
                    Console.WriteLine($"The area is { triangleArea }");

                    Console.WriteLine("Part 4, solving a quadratic equation");
                    Console.WriteLine("Enter an integer for A1");
                    string QuadA = Console.ReadLine();
                    double A1;
                    bool p6= double.TryParse(QuadA,out A1);
                    if(p6 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }
                    Console.WriteLine("Enter an integer for B1");
                    string QuadB = Console.ReadLine();
                    double B1;
                    bool p7= double.TryParse(QuadB,out B1);
                    if (p7 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }

                    Console.WriteLine("Enter an integer C1");
                    string QuadC = Console.ReadLine();
                    double C1;
                    bool p8= double.TryParse(QuadC,out C1);
                    if(p8 == false)
                    {
                        test = 3;
                        throw new FormatException("you must enter a number");
                    }
                    double positive_num = -B1 + Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double negative_num = -B1 - Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double denominator = 2 * A1;
                    Console.WriteLine($"The positive solution is {positive_num / denominator}");
                    Console.WriteLine($"The negative solution is {negative_num / denominator}");
                    test = 4;
                }
                if (test == 1)
                {
                    Console.WriteLine("Part 2, volume of a hemisphere. Enter an integer for the radius:");
                    double volume;
                    bool p2 = double.TryParse(Console.ReadLine(), out volume);
                    if (p2 == false)
                    {
                        test = 1;
                        throw new FormatException("You must enter a valid number");
                    }
                    if (volume <= 0)
                    {
                        test = 1;
                        throw new Exception("your number is out of range");

                    }
                    volume = (Convert.ToDouble(4) / Convert.ToDouble(3) * (Math.PI * (System.Math.Pow(volume, 3)))) / 2;
                    Console.WriteLine($"The volume is { volume }");

                    Console.WriteLine("Part 3, Area of a triangle (Heron's Formula).");
                    Console.WriteLine("Enter an integer for side 1:");
                    double a;
                    bool p3 = double.TryParse(Console.ReadLine(), out a);
                    if (p3 == false)
                    {
                        test = 2;
                        throw new FormatException("You must enter a valid number");

                    }
                    if (a <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range");

                    }
                    Console.WriteLine("Enter an Integer for side 2:");
                    double b;
                    bool p4 = double.TryParse(Console.ReadLine(), out b);
                    if (p4 == false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (b <= 0)
                    {
                        //we can add a different test number here to start the question here
                        test = 2;
                        throw new Exception("your number is out of range");

                    }
                    Console.WriteLine("Enter an integer for side 3:");
                    double c;
                    bool p5 = double.TryParse(Console.ReadLine(), out c);
                    if (p5 == false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (c <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range.");

                    }
                    double p = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
                    double triangleArea = Convert.ToDouble(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))));
                    Console.WriteLine($"The area is { triangleArea }");
                    Console.WriteLine("Part 4, solving a quadratic equation");
                    Console.WriteLine("Enter an integer for A1");
                    string QuadA = Console.ReadLine();
                    double A1;
                    bool p6 = double.TryParse(QuadA, out A1);
                    if (p6 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }
                    Console.WriteLine("Enter an integer for B1");
                    string QuadB = Console.ReadLine();
                    double B1;
                    bool p7 = double.TryParse(QuadB, out B1);
                    if (p7 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }

                    Console.WriteLine("Enter an integer C1");
                    string QuadC = Console.ReadLine();
                    double C1;
                    bool p8 = double.TryParse(QuadC, out C1);
                    if (p8 == false)
                    {
                        test = 3;
                        throw new FormatException("you must enter a number");
                    }
                    double positive_num = -B1 + Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double negative_num = -B1 - Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double denominator = 2 * A1;
                    Console.WriteLine($"The positive solution is {positive_num / denominator}");
                    Console.WriteLine($"The negative solution is {negative_num / denominator}");

                    test = 4;
                }
                if(test == 2)
                {
                    Console.WriteLine("Part 3, Area of a triangle (Heron's Formula).");
                    Console.WriteLine("Enter an integer for side 1:");
                    double a;
                    bool p3 = double.TryParse(Console.ReadLine(), out a);
                    if (p3 == false)
                    {
                        test = 2;
                        throw new FormatException("You must enter a valid number");

                    }
                    if (a <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range");

                    }
                    Console.WriteLine("Enter an Integer for side 2:");
                    double b;
                    bool p4 = double.TryParse(Console.ReadLine(), out b);
                    if (p4 == false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (b <= 0)
                    {
                        //we can add a different test number here to start the question here
                        test = 2;
                        throw new Exception("your number is out of range");

                    }
                    Console.WriteLine("Enter an integer for side 3:");
                    double c;
                    bool p5 = double.TryParse(Console.ReadLine(), out c);
                    if (p5 == false)
                    {
                        test = 2;
                        throw new FormatException("you must enter a valid number.");
                    }
                    if (c <= 0)
                    {
                        test = 2;
                        throw new Exception("your number is out of range.");

                    }
                    double p = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
                    double triangleArea = Convert.ToDouble(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))));
                    Console.WriteLine($"The area is { triangleArea }");
                    
                    Console.WriteLine("Part 4, solving a quadratic equation");
                    Console.WriteLine("Enter an integer for A1");
                    string QuadA = Console.ReadLine();
                    double A1;
                    bool p6 = double.TryParse(QuadA, out A1);
                    if (p6 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }
                    Console.WriteLine("Enter an integer for B1");
                    string QuadB = Console.ReadLine();
                    double B1;
                    bool p7 = double.TryParse(QuadB, out B1);
                    if (p7 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }

                    Console.WriteLine("Enter an integer C1");
                    string QuadC = Console.ReadLine();
                    double C1;
                    bool p8 = double.TryParse(QuadC, out C1);
                    if (p8 == false)
                    {
                        test = 3;
                        throw new FormatException("you must enter a number");
                    }
                    double positive_num = -B1 + Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double negative_num = -B1 - Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double denominator = 2 * A1;
                    Console.WriteLine($"The positive solution is {positive_num / denominator}");
                    Console.WriteLine($"The negative solution is {negative_num / denominator}");
                    test = 4;
                }
                if (test == 3)
                {
                    Console.WriteLine("Part 4, solving a quadratic equation");
                    Console.WriteLine("Enter an integer for A1");
                    string QuadA = Console.ReadLine();
                    double A1;
                    bool p6 = double.TryParse(QuadA, out A1);
                    if (p6 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }
                    Console.WriteLine("Enter an integer for B1");
                    string QuadB = Console.ReadLine();
                    double B1;
                    bool p7 = double.TryParse(QuadB, out B1);
                    if (p7 == false)
                    {
                        test = 3;
                        throw new FormatException("You must enter a number");
                    }

                    Console.WriteLine("Enter an integer C1");
                    string QuadC = Console.ReadLine();
                    double C1;
                    bool p8 = double.TryParse(QuadC, out C1);
                    if (p8 == false)
                    {
                        test = 3;
                        throw new FormatException("you must enter a number");
                    }
                    double positive_num = -B1 + Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double negative_num = -B1 - Math.Sqrt((B1 * B1) - 4 * A1 * C1);
                    double denominator = 2 * A1;
                    Console.WriteLine($"The positive solution is {positive_num / denominator}");
                    Console.WriteLine($"The negative solution is {negative_num / denominator}");
                    test = 4;
                }
            }
            catch (FormatException fEX)
            {
                //Console.WriteLine("This is the cathc test");
                Console.WriteLine($"test is {test} ");
                string jeff = fEX.Message;
                Console.WriteLine($"{jeff}");
                //EX1(test);
            }
            catch (Exception GR8TR0)
            {
                //Console.WriteLine("this is the grandaddy check");
                Console.WriteLine($"test is  {test}");
                string weesnaw = GR8TR0.Message;
                Console.WriteLine($"{weesnaw}");
                //EX1(test);
            }
            finally
            {
                Console.WriteLine("Okay");
                if(test != 4)
                {
                    EX1(test);
                }
            }
        }*/
    }
}
