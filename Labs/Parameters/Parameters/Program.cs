#region using directives

using System;
#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int jeff = 0;
            Console.WriteLine($"jeff is {jeff}");
            Pass.Value(jeff);
            Console.WriteLine($"jeff is {jeff}");
            jeff = Pass.setGeof();
            Console.WriteLine(jeff);

            Console.WriteLine("-----------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Pass.Value2(ref i);
            Console.WriteLine($"i is {i}");

            Console.WriteLine("-----------");

            //this is a int 
            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);//default number is set to 0
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);

            //this is a string
            Console.WriteLine(wi.Idontknow);//default string is set to NULL or ""
            Pass.Reference2(wi);
            Console.WriteLine(wi.Idontknow);

            //This is a bool 
            Console.WriteLine(wi.claymore);//default boolean is set to false
            Pass.Reference3(wi);
            Console.WriteLine(wi.claymore);
            
            Console.ReadKey();
           
            Duck daffy = new Duck();
            Console.WriteLine($"Daffy name is [{daffy.Name}]");
            daffy.Name = "Daffy";
            Console.WriteLine($"Daffy name is [{daffy.Name}]");

            daffy.setName("daffidal");
            Console.WriteLine($"Daffy's name is now {daffy.Name}");

            Duck huey = new Duck();
            huey.setName("Huey");
            Console.WriteLine($"Hueys name is {huey.Name}");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
