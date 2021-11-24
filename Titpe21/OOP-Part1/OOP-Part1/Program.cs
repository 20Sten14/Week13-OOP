using System;

namespace OOP_Part1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");
            }
            public string Name
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Woof-Woof!");
                happiness += 0.2;
            } 
            public void Wags()
            {
                Console.WriteLine($"{Name}: Wiggle-Wiggle");

            }

            public void Rename(string NewName)
            {
                name = NewName;
                /*Console.WriteLine($"Enter a new name for the dog {Mydog1.name}");*/
            }
             
            public void ShwoDogData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"spots:{spots}");
                Console.WriteLine($"level of happiness: {Happiness}");
            }






        }
       
        static void Main(string[] args)
        {
            Dog Mydog1 = new Dog("Pihkur", 10);
            Console.WriteLine($"{Mydog1.Name}'s level of happiness: {Mydog1.Happiness}");
            Dog Mydog2 = new Dog("Puhkur", 2);
            Console.WriteLine($"{Mydog2.Name}'s level of happiness: {Mydog2.Happiness}");


            while(Mydog1.Happiness != 1)
            {
                Mydog1.Barks();
            }

            Mydog1.Wags();

            Console.WriteLine($"Enter a new name for the dog{Mydog1.Name}");
            string userinput = Console.ReadLine();
            Mydog1.Rename(userinput);
            Mydog2.ShwoDogData();
        }



    }
}
