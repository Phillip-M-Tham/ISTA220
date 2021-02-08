using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'x';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.Write("How Many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");

        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Enter a score(use quit to exit): ");
            Console.WriteLine($"sum is {sum} count is {count}");
            string input = Console.ReadLine();
            if (input != "quit")
            {
                sum += int.Parse(input);
                count += 1;
                return AvgAnyInts(sum, count);
            }
            else
                Console.WriteLine($"sum is {sum} count is {count}");
                return sum / count;
        }

        private static double AvgUnkInts(int sum, int count, int usernum)
        {
            Console.WriteLine("Enter a score: ");
            Console.WriteLine($"sum is {sum} count is {count}");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count += 1;
            if (count != usernum)
                return AvgUnkInts(sum, count, usernum);
            else
                Console.WriteLine($"The sum is {sum}");
                Console.WriteLine($"count is {count} and user wanted to grade {usernum} scores. These two should be the same");
                return sum / usernum;
        }

        private static double AvgTenInts(double sum, double count)
        {
            Console.WriteLine("Enter a score: ");
            Console.WriteLine($"sum is {sum} count is {count}" );
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count += 1;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return sum / count;
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            count += 1;
            sum += int.Parse(input);
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
        
        private static char ConvertNumericToLetterGrade(double gradeNum)
        {
            char grade='x';
            if (gradeNum >= 90)
            {
                grade = 'A';
            }
            else if (gradeNum >= 80)
            {
                grade = 'B';
            }
            else if (gradeNum >= 70)
            {
                grade = 'C';
            }else if(gradeNum >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            return grade;
        }   
    }
}
