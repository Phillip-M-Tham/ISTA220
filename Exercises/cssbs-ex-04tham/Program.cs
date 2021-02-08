using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex_04tham
{
    class Program
    {
        static void Main(string[] args)
        {
            //THESE ARE MY HORSES
            Horse Jeff = new Horse("Jeff");
            Jeff.Speak();
            Jeff.Eat();
            Jeff.Walk();
            Horse Mystery = new Horse("Mystery");
            Mystery.Speak();
            Mystery.Eat();
            Mystery.Walk();
            Horse Leonidas = new Horse("Leonidas");
            Leonidas.Speak();
            Leonidas.Eat();
            Leonidas.Walk();
            Horse Shadowfax = new Horse("Shadowfax");
            Shadowfax.Speak();
            Shadowfax.Eat();
            Shadowfax.Walk();

            //THESE ARE MY GOATS
            Goat Pan = new Goat("Pan");
            Pan.Speak();
            Pan.Eat();
            Pan.Walk();
            Goat Soothsayer = new Goat("Soothsayer");
            Soothsayer.Speak();
            Soothsayer.Eat();
            Soothsayer.Walk();
            Goat Mr_Tumnus = new Goat("Mr. Tumnus");
            Mr_Tumnus.Speak();
            Mr_Tumnus.Eat();
            Mr_Tumnus.Walk();
            Goat Philoctetes = new Goat("Philoctetes");
            Philoctetes.Speak();
            Philoctetes.Eat();
            Philoctetes.Walk();

            //THESE ARE MY CHICKENS
            Chicken Chicken_Little = new Chicken("Chicken Little");
            Chicken_Little.Speak();
            Chicken_Little.Eat();
            Chicken_Little.Walk();
            Chicken Heihei = new Chicken("Heihei");
            Heihei.Speak();
            Heihei.Eat();
            Heihei.Walk();
            Chicken Foghorn = new Chicken("Foghorn");
            Foghorn.Speak();
            Foghorn.Eat();
            Foghorn.Walk();
            Chicken Piu = new Chicken("Piu Piu");
            Piu.Speak();
            Piu.Eat();
            Piu.Walk();

            //THESE ARE MY RABBITS
            Rabbit Peter = new Rabbit("Peter");
            Peter.Speak();
            Peter.Eat();
            Peter.Walk();
            Rabbit Bugs_Bunny = new Rabbit("Bugs Bunny");
            Bugs_Bunny.Speak();
            Bugs_Bunny.Eat();
            Bugs_Bunny.Walk();
            Rabbit Judy = new Rabbit("Judy Hopps");
            Judy.Speak();
            Judy.Eat();
            Judy.Walk();
            Rabbit Trix = new Rabbit("Trix");
            Trix.Speak();
            Trix.Eat();
            Trix.Walk();
        }
    }

    class Horse
    {
        private string _name;
        private string _species;
        private string _mynoise;
        private string _myfood;
        private string _mymovement;
        public Horse()
        {
            _name = "";
            _species = "";
            _mynoise = "";
            _myfood = "";
            _mymovement = "";
        }
        public Horse(string myname)
        {
            _name = myname;
            _species = "horse";
            Console.WriteLine($"I am a {_species} and my name is {_name}");
            _mynoise = "I say neigh";
            _myfood = "I eat oats";
            _mymovement = "I trot and canter";
        }
        public void Speak()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mynoise}");
            //we can do the noise here
        }
        public void Eat()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_myfood}");
        }
        public void Walk()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mymovement}");
        }
    }
    class Goat
    {
        private string _name;
        private string _species;
        private string _mynoise;
        private string _myfood;
        private string _mymovement;
        public Goat()
        {
            _name = "";
            _species = "";
            _mynoise = "";
            _myfood = "";
            _mymovement = "";
        }
        public Goat(string myname)
        {
            _name = myname;
            _species = "goat";
            Console.WriteLine($"I am a {_species} and my name is {_name}");
            _mynoise = "I say bleat";
            _myfood = "I eat hay";
            _mymovement = "I climb and walk";
        }
        public void Speak()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mynoise}");
            //we can do the noise here
        }
        public void Eat()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_myfood}");
        }
        public void Walk()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mymovement}");
        }
    }
    class Chicken
    {
        private string _name;
        private string _species;
        private string _mynoise;
        private string _myfood;
        private string _mymovement;
        public Chicken()
        {
            _name = "";
            _species = "";
            _mynoise = "";
            _myfood = "";
            _mymovement = "";
        }
        public Chicken(string myname)
        {
            _name = myname;
            _species = "chicken";
            Console.WriteLine($"I am a {_species} and my name is {_name}");
            _mynoise = "I say cluck, cluck, cluck";
            _myfood = "I eat corn";
            _mymovement = "I run around and peck things";
        }
        public void Speak()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mynoise}");
            //we can do the noise here
        }
        public void Eat()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_myfood}");
        }
        public void Walk()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mymovement}");
        }
    }
    class Rabbit
    {
         private string _name;
         private string _species;
         private string _mynoise;
         private string _myfood;
         private string _mymovement;
        public Rabbit()
        {
            _name = "";
            _species = "";
            _mynoise = "";
            _myfood = "";
            _mymovement = "";
        }
        public Rabbit(string myname)
        {
            _name = myname;
            _species = "rabbit";
            Console.WriteLine($"I am a {_species} and my name is {_name}");
            if (_name == "Bugs Bunny")
            {
                _mynoise = "I say Eh what's up doc?";
            }
            else if (_name == "Judy Hopps")
            {
                _mynoise = "I say Sweet Cheese and Crackers";
            }
            else
            {
                _mynoise = "I say squeek";
            }
            _myfood = "I eat carrots";
            _mymovement = "I hop around";
        }
        public void Speak()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mynoise}");
            //we can do the noise here
        }
        public void Eat()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_myfood}");
        }
        public void Walk()
        {
            Console.WriteLine($"My name is {_name}. I am a {_species} and {_mymovement}");
        }
    }
}
