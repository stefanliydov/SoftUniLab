using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IQ { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCo { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dog> Dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> Cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> Snakes = new Dictionary<string, Snake>();
        
            string input = Console.ReadLine();

            while( input != "I'm your Huckleberry")
            {
                string[] splited = input.Split(' ').ToArray();
                if (splited.Length > 2)
                {
                    string animal = splited[0];
                    string name = splited[1];
                    int age = int.Parse(splited[2]);
                    int parameter = int.Parse(splited[3]);

                    switch (animal)
                    {
                        case "Dog":
                            Dog newDog = new Dog()
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = parameter
                            };
                            
                            Dogs[newDog.Name] = newDog;
                            break;
                        case "Cat":
                            Cat newCat = new Cat()
                            {
                                Name = name,
                                Age = age,
                                IQ = parameter
                            };

                            Cats.Add(newCat.Name, newCat);
                            break;
                        case "Snake":
                            Snake newSnake = new Snake()
                            {
                                Name = name,
                                Age = age,
                                CrueltyCo = parameter
                            };

                            Snakes.Add(newSnake.Name, newSnake);
                            break;
                    }
                }
                else
                {
                    var name = splited[1];
                    if (Dogs.ContainsKey(name))
                        Dogs[name].ProduceSound();
                    else if (Cats.ContainsKey(name))
                        Cats[name].ProduceSound();
                    else if (Snakes.ContainsKey(name))
                        Snakes[name].ProduceSound();
                }

                input = Console.ReadLine();
            }

            foreach (var dog in Dogs)
                Console.WriteLine($"Dog: {dog.Value.Name}, Age: {dog.Value.Age}, Number Of Legs: {dog.Value.NumberOfLegs}");

            foreach (var cat in Cats)
                Console.WriteLine($"Cat: {cat.Value.Name}, Age: {cat.Value.Age}, IQ: {cat.Value.IQ}");

            foreach (var snake in Snakes)
                Console.WriteLine($"Snake: {snake.Value.Name}, Age: {snake.Value.Age}, Cruelty: {snake.Value.CrueltyCo}");
            
        }  
    }   
}
