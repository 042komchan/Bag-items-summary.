using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();
        
        Console.Write("Yo, how many items you got in your bag?: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"Give me the deets for item #{i}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Type (but not 'ShowAll', that's whack): ");
            string type = Console.ReadLine();

            if (!items.ContainsKey(type))
            {
                items[type] = new List<string>();
            }

            items[type].Add(name);
        }

        while (true)
        {
            Console.Write("\nType in your search term (or 'ShowAll' to see all your items): ");
            string searchTerm = Console.ReadLine();

            if (searchTerm == "End")
            {
                Console.WriteLine("Peace out, homie!");
                break;
            }

            if (searchTerm == "ShowAll")
            {
                Console.WriteLine("\nHere's everything you got in your bag:");
                foreach (var item in items)
                {
                    foreach (string name in item.Value)
                    {
                        Console.WriteLine($"- {name} ({item.Key})");
                    }
                }
            }
            else if (items.ContainsKey(searchTerm))
            {
                Console.WriteLine($"\nHere's all your {searchTerm} items:");
                foreach (string name in items[searchTerm])
                {
                    Console.WriteLine($"- {name}");
                }
            }
            else
            {
                Console.WriteLine("Yo, that's not a valid search term, try again.");
            }
        }
    }
}