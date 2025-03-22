using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initializing the dictionary
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        // Populating the dictionary initially with some default values
        myDictionary.Add("Aligator", "An aquatic reptile that eats meat.");
        myDictionary.Add("Crocodile", "An aqutic reptile similar to the Aligator.");
        myDictionary.Add("Bat", "A small nocturnal mammal capable of flight.");

        bool continueRunning = true;

        while (continueRunning)
        {
            // Displaying menu options in the console
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Populate the Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option (1-7): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PopulateDictionary(myDictionary);
                    break;

                case 2:
                    DisplayDictionaryContents(myDictionary);
                    break;

                case 3:
                    RemoveKey(myDictionary);
                    break;

                case 4:
                    AddNewKeyValuePair(myDictionary);
                    break;

                case 5:
                    AddValueToExistingKey(myDictionary);
                    break;

                case 6:
                    SortKeys(myDictionary);
                    break;

                case 7:
                    continueRunning = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }

    // Method to populate the dictionary
    static void PopulateDictionary(Dictionary<string, string> dict)
    {
        dict.Add("Giraffe", "A large mammal/herbivore with a long neck.");
        dict.Add("Octopus", "An aquatic creature with 8 arms and capable of shooting ink.");
        Console.WriteLine("Dictionary populated with new items.");
    }

    // Method to display dictionary contents
    static void DisplayDictionaryContents(Dictionary<string, string> dict)
    {
        Console.WriteLine("\nDictionary Contents:");
        foreach (KeyValuePair<string, string> entry in dict)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    // Method to remove a key from the dictionary
    static void RemoveKey(Dictionary<string, string> dict)
    {
        Console.Write("Enter the key to remove: ");
        string keyToRemove = Console.ReadLine();

        if (dict.ContainsKey(keyToRemove))
        {
            dict.Remove(keyToRemove);
            Console.WriteLine($"Key '{keyToRemove}' removed from the dictionary.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToRemove}' not found in the dictionary.");
        }
    }

    // Method to add a new key and value to the dictionary
    static void AddNewKeyValuePair(Dictionary<string, string> dict)
    {
        Console.Write("Enter the new key: ");
        string newKey = Console.ReadLine();
        Console.Write("Enter the new value: ");
        string newValue = Console.ReadLine();

        if (!dict.ContainsKey(newKey))
        {
            dict.Add(newKey, newValue);
            Console.WriteLine($"New key-value pair ('{newKey}', '{newValue}') added to the dictionary.");
        }
        else
        {
            Console.WriteLine($"Key '{newKey}' already exists in the dictionary.");
        }
    }

    // Method to add a value to an existing key
    static void AddValueToExistingKey(Dictionary<string, string> dict)
    {
        Console.Write("Enter the key to update: ");
        string keyToUpdate = Console.ReadLine();

        if (dict.ContainsKey(keyToUpdate))
        {
            Console.Write("Enter the new value to append: ");
            string valueToAppend = Console.ReadLine();

            dict[keyToUpdate] = dict[keyToUpdate] + " " + valueToAppend;
            Console.WriteLine($"Value for key '{keyToUpdate}' updated.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToUpdate}' not found in the dictionary.");
        }
    }

    // Method to sort the dictionary keys
    static void SortKeys(Dictionary<string, string> dict)
    {
        Console.WriteLine("\nSorted Keys:");
        foreach (var key in new SortedList<string, string>(dict))
        {
            Console.WriteLine(key.Key);
        }
    }
}

