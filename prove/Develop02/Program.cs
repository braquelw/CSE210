using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int user_choice = 0;

        List<JournalEntry>_entries = new List<JournalEntry>();

        // Welcome the user
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        // Menu Items
        while (user_choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string user_input = Console.ReadLine();
            user_choice = int.Parse(user_input);
            Console.WriteLine("");

            // If user chooses 1. Write
            if (user_choice == 1)
            {
                string entryPrompt = PromptGenerator();
                Console.WriteLine(entryPrompt);
                string entryResponse = UserResponse();
                string entryDate = GenerateDate();
                Console.WriteLine();

                // Add Entry
                JournalEntry entry = AddJournalEntry(entryDate, entryPrompt, entryResponse);

                // Add Entry to Journal
                _entries.Add(entry);
            }

            // If user chooses 2. Display
            if (user_choice == 2)
            {
                foreach (JournalEntry i in _entries)
                {
                    i.DisplayEntry();
                }
            }

            // If user chooses 3. Load
            if (user_choice == 3)
            {
                foreach (JournalEntry i in _entries)
                {
                    File.WriteAllLines("myJournal.txt", _entries);
                }
            }

            // If user chooses 4. Save
            if (user_choice == 4)
            {
                
            }

            // If user chooses 5. Quit
            if (user_choice == 5)
            {
                
            }
        }

        // Functions

        static string PromptGenerator()
        {
            // Create a list of journal prompts
            List<String> prompts = new List<String>()
            {
                "Who was the most interesting person I interacted with today?",
                "The best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "How did I connect with my family today?",
                "What was something I did to serve another today?",
                "Who made me feel loved today?",
                "Three things I'm grateful for",
                "How did I feel prompted today?",
                "If I could never forget one thing from today, what would it be?",
                "Overall, how did today go?",
                "How did you show yourself love today?",
                "I am proud of myself because...",
                "Some of my current goals",
                "A happy memory",
                "A funny moment",
                "Something I'm looking forward to",
                "The best part of my day",
                "Something I have recently learned",
                "If I could travel into the past...",
                "If I could do anything, what would I do?"
            };
            // Create a random instance
            Random R = new Random();
            int index = R.Next(prompts.Count);
            string randomString = prompts[index];
            return randomString;
        }
            
        static string GenerateDate()
        {
            // Add the current date
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            return dateText;
        }

        static string UserResponse()
        {
            // Display random prompt and let user answer
            string promptAnswer = Console.ReadLine();
            return promptAnswer;
        }

        static JournalEntry AddJournalEntry(string entryDate, string entryPrompt, string entryResponse)
        {
            JournalEntry entry = new JournalEntry();
            entry._dateOfEntry = entryDate;
            entry._prompt = entryPrompt;
            entry._response = entryResponse;

            return entry;
        }      
    }
}