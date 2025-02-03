using System;
using System.Collections.Generic;

class Program
{
    static void PopulateDictionary(Dictionary<string, string> data)
    {
        Console.Write("Enter number of entries: ");
        int numEntries = int.Parse(Console.ReadLine());
        for (int i = 0; i < numEntries; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            Console.Write("Enter value: ");
            string value = Console.ReadLine();
            data[key] = value;
        }
        Console.WriteLine("Dictionary populated successfully.");
    }

    static void DisplayDictionary(Dictionary<string, string> data)
    {
        Console.WriteLine("Dictionary contents:");
        foreach (var entry in data)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    static void RemoveKey(Dictionary<string, string> data)
    {
        Console.Write("Enter key to remove: ");
        string key = Console.ReadLine();
        if (data.Remove(key))
        {
            Console.WriteLine("Key removed successfully.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    static void AddNewKeyValue(Dictionary<string, string> data)
    {
        Console.Write("Enter new key: ");
        string key = Console.ReadLine();
        Console.Write("Enter value: ");
        string value = Console.ReadLine();
        data[key] = value;
        Console.WriteLine("New key-value pair added.");
    }

    static void AddValueToExistingKey(Dictionary<string, string> data)
    {
        Console.Write("Enter key to add value to: ");
        string key = Console.ReadLine();
        if (data.ContainsKey(key))
        {
            Console.Write("Enter additional value: ");
            string additionalValue = Console.ReadLine();
            data[key] += ", " + additionalValue;
            Console.WriteLine("Value added successfully.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }

    static void SortKeys(Dictionary<string, string> data)
    {
        List<string> sortedKeys = new List<string>(data.Keys);
        sortedKeys.Sort();
        Console.WriteLine("Sorted keys:");
        foreach (string key in sortedKeys)
        {
            Console.WriteLine(key);
        }
    }

    static void Main()
    {
        Dictionary<string, string> data = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PopulateDictionary(data);
                    break;
                case "2":
                    DisplayDictionary(data);
                    break;
                case "3":
                    RemoveKey(data);
                    break;
                case "4":
                    AddNewKeyValue(data);
                    break;
                case "5":
                    AddValueToExistingKey(data);
                    break;
                case "6":
                    SortKeys(data);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
