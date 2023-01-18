using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string userInput = "";

        // Reference Lists
        List<string> books = new List<string>
        {
            "1 Nephi", "2 Nephi", "2 Nephi", "2 Nephi", "2 Nephi", "Mosiah", "Mosiah", "Alma", "Alma", "Helaman", "3 Nephi", "3 Nephi", "Ether"
        };
        List<int> chapters = new List<int>
        {
            3, 2, 2, 9, 25, 2, 4, 32, 37, 5, 12, 18, 12
        };
        List<int> startVerses = new List<int>
        {
            7, 25, 27, 28, 26, 17, 30, 21, 35, 12, 48, 20, 27
        };
        List<int> endVerses = new List<int>
        {
            0, 0, 0, 29, 0, 0, 0, 0, 0, 0, 0, 21, 0
        };

        // Get a Random Reference
        Random I = new Random();
        int index = I.Next(books.Count);
        string book = books[index];
        int chapter = chapters[index];
        int verseStart = startVerses[index];
        int verseEnd = endVerses[index];

        // Get the Reference as a string
        Reference r = new Reference(book, chapter, verseStart, verseEnd);
        string newRef = r.GetReference();

        // Add the scripture text
        string scriptureText = FindReference(newRef);

        // Get the scripture put together with the reference
        string scriptureAndRef = ScriptureWrite(newRef, scriptureText);
        Console.Clear();
        Console.WriteLine("Press 'Enter' to remove some words OR type 'quit' to Exit.");
        Console.WriteLine();
        Console.WriteLine(scriptureAndRef);
        userInput = Console.ReadLine();
        Console.Clear();

        // Generate new Scripture with 3 words missing each time the user presses "enter". Exit when the user types quit OR all the letters are gone.
        while (userInput != "quit")
        {
            if (scriptureText.Any(char.IsLetter))
            {
                scriptureText = TakeAwayThree(scriptureText);
                string newScriptureAndRef = ScriptureWrite(newRef, scriptureText);
                Console.WriteLine("Press 'Enter' to remove some words OR type 'quit' to Exit.");
                Console.WriteLine();
                Console.WriteLine(newScriptureAndRef);
                userInput = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        // Functions
        // Get a random reference
        // Write the Reference and Scripture
        static string ScriptureWrite(string newRef, string scriptureText)
        {
            Scripture s = new Scripture(newRef, scriptureText);
            string newscripture = s.GetScripture();
            return newscripture;
        }
        // Take Away 3 Words from the Scripture Text
        static string TakeAwayThree(string scriptureText)
        {
            string wordToChange = WordGenerator(scriptureText);
            string replacedWord = WordReplacement(wordToChange);
            string modifiedScripture = ScriptureModification(wordToChange, replacedWord, scriptureText);
            string wordToChange2 = WordGenerator(modifiedScripture);
            string replacedWord2 = WordReplacement(wordToChange2);
            string modifiedScripture2 = ScriptureModification(wordToChange2, replacedWord2, modifiedScripture);
            string wordToChange3 = WordGenerator(modifiedScripture2);
            string replacedWord3 = WordReplacement(wordToChange3);
            string modifiedScripture3 = ScriptureModification(wordToChange3, replacedWord3, modifiedScripture2);
            return modifiedScripture3;
        }
        // Get the Word from the Random Index Number
        static string WordGenerator(string scriptureText)
        {
            if (scriptureText.Any(char.IsLetter))
            {
                List<string> wordList = scriptureText.Split(' ').ToList();
                string randomWord = "";
                while (!randomWord.Any(char.IsLetter))
                {
                    Random R = new Random();
                    int index = R.Next(wordList.Count);
                    randomWord = wordList[index];
                }
                return randomWord;
            }
            else
            {
                return "";
            }
        }
        // Replace the random word with underscores
        static string WordReplacement(string wordToChange)
        {
            Word w = new Word(wordToChange);
            string newWord = w.GetUnderscores();
            return newWord;
        }
        // Modify the scripture with the underscore words
        static string ScriptureModification(string wordToChange, string replacedWord, string scriptureText)
        {
            var split_options = new[] {' ', '.', ',', ':'};
            var input = scriptureText.Split(split_options, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(wordToChange))
                input[i] = replacedWord;
            }
            string modified = string.Join(" ", input);
            return modified;
        }
        // Get a new scripture to work on memorizing
        static string FindReference(string newRef)
        {
            // A list of Scriptures
            var scriptureDict = new Dictionary<string, string>
            {
                ["1 Nephi 3:7"] = "And it came to pass that I, Nephi, Said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
                ["2 Nephi 2:25"] = "Adam fell that men might be; and men are, that they might have joy.",
                ["2 Nephi 2:27"] = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.",
                ["2 Nephi 9:28-29"] = "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.",
                ["2 Nephi 25:26"] = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may knoww to what source they may look for a remission of their sins.",
                ["Mosiah 2:17"] = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
                ["Mosiah 4:30"] = "But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not.",
                ["Alma 32:21"] = "And now as I said concerning faith -- faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.",
                ["Alma 37:35"] = "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.",
                ["Helaman 5:12"] = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.",
                ["3 Nephi 12:48"] = "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect.",
                ["3 Nephi 18:20-21"] = "And whatsoever ye shall ask the Father in my name, which is right, believing that ye shall receive, behold it shall be given unto you. Pray in your families unto the Father, always in my name, that your wives and your children may be blessed.",
                ["Ether 12:27"] = "And if men come unto me i will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
            };
            // Find the scripture that goes with the reference
            var scriptureText = scriptureDict[newRef];
            return scriptureText;
        }
    }
}