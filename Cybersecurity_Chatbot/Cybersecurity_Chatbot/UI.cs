using System;
using System.Media;

namespace Cybersecurity_Chatbot
{
    internal class UI
    {
        /**
         * This class contains methods for displaying messages and menus to the user
         * It also handles user prompts for continuing or exiting the chatbot.
         */
        public static void WelcomeMessage()
        {
            try 
            {
                SoundPlayer welcome = new SoundPlayer("welcome.wav");                                                            //Attempts to play a welcome sound when the chatbot starts
                welcome.Play();                                                                                                  //Plays the welcome sound
            }
            catch (Exception e)                                                                                                //If sound cannot be played, it'll catch it here and display error message
            {
                Console.WriteLine("Bot: Unable to play welcome sound. " + e.Message);
            }

            Console.WriteLine("Bot: Hello! Welome to Cybersecurity Awareness Bot.");
            Console.WriteLine("Bot: I am here to help you stay safe online.");
            Console.WriteLine();
        }

        public static void TopicMenu()
        {
            Console.WriteLine("Choose a topic:");
            Console.WriteLine("1) Phishing emails");
            Console.WriteLine("2) Passwords");
            Console.WriteLine("3) Suspicious links");
            Console.WriteLine("4) Exit");
        }

        public static void ExitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: Thanks for chatting. Stay alert online and keep your accounts secure.");
        }

        public static void InvalidOption()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: I can help with phishing, passwords, or suspicious links.");
            Console.WriteLine("Bot: Please type a topic name, number (1-4), or 'exit'.");
        }

        public static void GoodbyeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: Great job learning about online safety. Goodbye.");
        }

        public static bool AskToContinue()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Bot: Would you like to learn about another topic? (Y/N): ");
                string response = Console.ReadLine();                                                                   //Reads user input
                string answer = InputValidation.InputHandler(response);                                                 //Calls the InputHandler method to validate and standardize the input

                if (answer == "yes" || answer == "y")                                                                   //If user types yes or y, it'll be treated as yes and program will continue
                {
                    Console.WriteLine(); 
                    return true;
                }

                if (answer == "no" || answer == "n" || answer == "exit")                                                //If user types exit,n or no, it'll be treated as no and program will end
                {
                    return false;
                }

                Console.WriteLine("Bot: Please answer with 'Y' or 'N'.");                                               //Prompt user again if they enter an invalid response
            }
        }
    }
}
