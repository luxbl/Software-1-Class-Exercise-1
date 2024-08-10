using System;
using System.Text.Json;

namespace Petstore1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    Console.WriteLine("What product would you like to add? (CatFood/DogLeash)");
                    string productType = Console.ReadLine();

                    if (productType.ToLower() == "catfood")
                    {
                        CatFood catFood = new CatFood();

                        Console.WriteLine("Enter the name of the cat food:");
                        catFood.Name = Console.ReadLine();

                        Console.WriteLine("Enter the price:");
                        catFood.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the quantity:");
                        catFood.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the description:");
                        catFood.Description = Console.ReadLine();

                        Console.WriteLine("Enter the weight in pounds:");
                        catFood.WeightPounds = double.Parse(Console.ReadLine());

                        Console.WriteLine("Is this kitten food? (true/false):");
                        catFood.KittenFood = bool.Parse(Console.ReadLine());

                        Console.WriteLine("Product added:");
                        Console.WriteLine(JsonSerializer.Serialize(catFood));
                    }
                    else if (productType.ToLower() == "dogleash")
                    {
                        DogLeash dogLeash = new DogLeash();

                        Console.WriteLine("Enter the name of the dog leash:");
                        dogLeash.Name = Console.ReadLine();

                        Console.WriteLine("Enter the price:");
                        dogLeash.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the quantity:");
                        dogLeash.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the description:");
                        dogLeash.Description = Console.ReadLine();

                        Console.WriteLine("Enter the length in inches:");
                        dogLeash.LengthInches = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the material:");
                        dogLeash.Material = Console.ReadLine();

                        Console.WriteLine("Product added:");
                        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    }
                    else
                    {
                        Console.WriteLine("Invalid product type. Please choose either 'CatFood' or 'DogLeash'.");
                    }
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
        }
    }
}