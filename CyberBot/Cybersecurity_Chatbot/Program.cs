using System;


namespace Cybersecurity_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logo.AnimatedLogo();                                                                                        //Display the logo of the chatbot 
            UI.GetUserData();                                                                                           //Get user data (name, etc.) for a personalized experience    
            UI.WelcomeMessage();                                                                                        //Start the chatbot by displaying a welcome message

            while (true)
            {
                UI.TopicMenu();
                Console.Write("You: ");                                                                                 // Prompt the user for input
                string userInput = Console.ReadLine();

                string topic = InputValidation.InputHandler(userInput);                                                 // Validate and process the user input to determine the topic

                if (topic == "exit")
                {
                    UI.ExitMessage();
                    break;
                }

                bool wasHandled = ResponseSystem.TryHandleTopic(topic);                                                 // Handles a topic and provides a response

                if (!wasHandled)
                {
                    UI.InvalidOption();
                }

                if (!UI.AskToContinue())
                {
                    UI.GoodbyeMessage();
                    break;
                }
            }
        }
    }
}
        

