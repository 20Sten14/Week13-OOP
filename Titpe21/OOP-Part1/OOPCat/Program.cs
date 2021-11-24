using System;

namespace OOP_Part1
{
    class Program
    {
        class Dog
        {
            string name;
            int color;
            double hungryness;

            public Dog(string _name, int _color)
            {
                name = _name;
                color = _color;
                hungryness = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }
            public string Name
            {
                get { return name; }
            }
            public int Color
            {
                get { return Color; }
            }
            public double Hungryness
            {
                get { return hungryness; }
            }
            public void Barks()
            {
                Console.WriteLine("zzzzzzzzzz!");
                hungryness += 0.2;
            }
            public void Wags()
            {
                Console.WriteLine($"{Name}: Says Meow");

            }

            public void Rename(string NewName)
            {
                name = NewName;
                /*Console.WriteLine($"Enter a new name for the dog {Mydog1.name}");*/
            }

            public void ShwoDogData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"color:{color}");
                Console.WriteLine($"level of hungryness: {Hungryness}");
            }






        }

        static void Main(string[] args)
        {
            Dog Mydog1 = new Dog("Pihkur", 10);
            Console.WriteLine($"{Mydog1.Name}'s level of Hungryness: {Mydog1.Hungryness}");
            Dog Mydog2 = new Dog("Puhkur", 2);
            Console.WriteLine($"{Mydog2.Name}'s level of Hungryness: {Mydog2.Hungryness}");


            while (Mydog1.Hungryness != 1)
            {
                Mydog1.Barks();
            }

            Mydog1.Wags();

            Console.WriteLine($"Enter a new name for the cat{Mydog1.Name}");
            string userinput = Console.ReadLine();
            Mydog1.Rename(userinput);
            Mydog2.ShwoDogData();
        }



    }
}
