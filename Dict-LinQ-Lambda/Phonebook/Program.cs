using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            var data = Console.ReadLine().Split();

            var phonebook = new Dictionary<string, string>();

            while (data[0] != "END")
            {
                switch (data[0])
                {
                    case "A":

                        string name = data[1];
                        string number = data[2];

                        if (!phonebook.ContainsKey(name))
                        {
                            phonebook[name] = number;
                        }

                        else
                        {
                            phonebook[name] = number;
                        }
                        break;

                    case "S":

                        string nameCheck = data[1];

                        if (phonebook.ContainsKey(nameCheck))
                        {
                            string value = phonebook[nameCheck];
                            Console.WriteLine($"{nameCheck} -> {value}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {nameCheck} does not exist.");
                        }
                        break;
                }

                data = Console.ReadLine().Split();
            }
        }
    }
}
