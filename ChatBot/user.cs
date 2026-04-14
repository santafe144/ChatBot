using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class User
    {
        public string Name { get; set; }

        public void GetUserName()
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(Name))
            {
                Console.Write("Name cannot be empty. Try again: ");
                Name = Console.ReadLine();
            }

            Console.WriteLine($"Hello, {Name}! 👋");
        }
    }
}