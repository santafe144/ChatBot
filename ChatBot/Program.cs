using ChatBot;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play greeting sound
            AudioPlayer.PlayGreeting();

            // Show ASCII Art
            Chatbot.DisplayLogo();

            // Get user
            User user = new User();
            user.GetUserName();

            // Start chatbot
            Chatbot bot = new Chatbot(user);
            bot.StartChat();

            Console.ReadLine();
        }
    }
}