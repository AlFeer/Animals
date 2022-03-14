using System;
using Animals.Models;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter common name of Animal");
            string name = Console.ReadLine();

            Console.WriteLine("Enter type of Animal");
            string type = Console.ReadLine();

            Console.WriteLine("Enter sort of Animal");
            string sort = Console.ReadLine();

            Console.WriteLine("Enter color of Animal");
            string color = Console.ReadLine();


        AgeInput:
            Console.WriteLine("Enter age of Animal");
            string ageInput = Console.ReadLine();
            int age;
            try
            {
                age = int.Parse(ageInput);

            }
            catch (Exception)
            {
                Console.WriteLine("Enter age of Animal");
                goto AgeInput;
            }
        LegsInput:

            Console.WriteLine("Enter legs count of Animal");
            string legsInput = Console.ReadLine();
            int legsCount;
            try
            {
                legsCount = int.Parse(legsInput);

            }
            catch (Exception)
            {
                Console.WriteLine("Enter legs count of Animal");
                goto LegsInput;
            }

            Console.WriteLine("Enter name of Horse");
            string horseName = Console.ReadLine();


        HeightInput:
            Console.WriteLine("Enter height of Horse");
            string Height = Console.ReadLine();
            int height;
            try
            {
                height = int.Parse(Height);

            }
            catch (Exception)
            {
                Console.WriteLine("Enter speed of Horse");
                goto HeightInput;
            }

            Console.WriteLine("Animal: " + name + " " + "Sort: " + sort + " " + "Type: " + type + " " + "Color: " + color + " " + "Age: " + age + " " + "Legs count: " + legsCount + " " + "Name of Horse: " + horseName + " " + "Height: " + height);


            GetHorseName();
        }
        /// <summary>
        /// Horse speed
        /// </summary>
        static void GetHorseName()
        {
            int horseSpeed = 70;
            Console.WriteLine("Horse speed is: " + horseSpeed);
        }

    }
}


