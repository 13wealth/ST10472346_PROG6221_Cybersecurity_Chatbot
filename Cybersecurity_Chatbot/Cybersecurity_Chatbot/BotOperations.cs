using System;

namespace Cybersecurity_Chatbot
{
    internal class BotOperations
    {

        /**
         * Tries to handle the given topic by providing an explanation.
         * @param topic The topic to handle.
         * @return True if the topic was handled; otherwise, false.
         */
        public static bool TryHandleTopic(string topic)
        {
            switch (topic)
            {
                /*
                 * Multiple case labels allow for different variations.
                 * If input is any of these variations, call the method to explain phishing
                 * if no match is found, it will return false and show the invalid option message
                 */
                case "phishing":
                case "phishing email":
                case "phishing emails":
                    ExplainPhishing();                                                                                  //Call the method to explain phishing
                    return true;

                case "password":
                case "passwords":
                    ExplainPasswords();                                                                                 //Call the method to explain passwords
                    return true;

                case "suspicious link":
                case "suspicious links":
                case "links":
                    ExplainSuspiciousLinks();                                                                           //Call the method to explain suspicious links
                    return true;

                default:
                    return false;                                                                                       //No matching topic found
            }
        }

        private static void ExplainPhishing()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: Phishing is when attackers pretend to be trusted companies or people to steal your information.");
            Console.WriteLine("Bot: Warning signs include urgent language, spelling mistakes, and requests for passwords or banking details.");
            Console.WriteLine("Bot: Safety tip: Do not click links in unexpected messages. Contact the company using an official website.");
        }

        private static void ExplainPasswords()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: Strong passwords protect your accounts from being guessed or cracked.");
            Console.WriteLine("Bot: Use long passphrases, avoid personal information, and never reuse the same password on multiple sites.");
            Console.WriteLine("Bot: Safety tip: Use a password manager and enable multi-factor authentication where possible.");
        }

        private static void ExplainSuspiciousLinks()
        {
            Console.WriteLine();
            Console.WriteLine("Bot: Suspicious links can lead to fake websites, malware downloads, or scams.");
            Console.WriteLine("Bot: Hover over links to preview the real address and watch for misspelled domains.");
            Console.WriteLine("Bot: Safety tip: If unsure, do not click. Type the official website address directly into your browser.");
        }
    }
}
