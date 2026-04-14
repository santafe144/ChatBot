using ChatBot;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Chatbot
    {
        private User user;

        public Chatbot(User user)
        {
            this.user = user;
        }

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   _____           _               ____        _   
  / ____|         | |             |  _ \      | |  
 | |     _   _ ___| |_ ___  _ __  | |_) | ___ | |_ 
 | |    | | | / __| __/ _ \| '__| |  _ < / _ \| __|
 | |____| |_| \__ \ || (_) | |    | |_) | (_) | |_ 
  \_____|\__,_|___/\__\___/|_|    |____/ \___/ \__|
            CYBER SECURITY BOT
");

            Console.ResetColor();
        }

        public void StartChat()
        {
            Console.WriteLine($"\nHi {user.Name}, ask me anything about cybersecurity!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                if (input.Contains("exit"))
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online 🔐");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");

            if (input.Contains("how are you"))
            {
                TypeEffect("I'm just a bot, but I'm functioning perfectly!");
            }
            else if (input.Contains("purpose"))
            {
                TypeEffect("My purpose is to help you stay safe online.");
            }
            else if (input.Contains("password"))
            {
                TypeEffect("Use strong passwords with letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                TypeEffect("Phishing is when attackers trick you into giving personal info.");
            }
            else
            {
                TypeEffect("I don't understand that yet, but I'm learning!");
            }

            Console.ResetColor();
        }

        private void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }
}