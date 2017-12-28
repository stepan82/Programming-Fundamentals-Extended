using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main()
        {
            var contacts = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                contacts[name] = email;
            }

            foreach (var contact in contacts.ToList())
            {
                if (contact.Value.LastIndexOf(".uk") != -1 || contact.Value.LastIndexOf(".us") != -1)
                {
                    contacts.Remove(contact.Key);
                }
            }

            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
