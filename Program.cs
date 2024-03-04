/*
 * Author: Ethen Gonzalez
 * Course: COMP003A
 * Purpose: Replicate Basic Data Structures Output
 */

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array - CharacterCounter Section
            Console.WriteLine("************************************************************");
            Console.WriteLine("             Array - CharacterCounter Section");
            Console.WriteLine("************************************************************");
            Console.Write("Please enter a letter: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();
            int count = CharacterCounter(letter, word);
            Console.WriteLine($"There are {count} letter {letter} in the word {word}");

            // Array - IsPalindrome Section
            Console.WriteLine("************************************************************");
            Console.WriteLine("\n            Array - IsPalindrome Section");
            Console.WriteLine("************************************************************");
            Console.Write("Please enter a word to check if it is a palindrome: ");
            string inputWord = Console.ReadLine();
            bool isPalindrome = IsPalindrome(inputWord);
            Console.WriteLine($"The word '{inputWord}' is a palindrome: {isPalindrome}");

            // List - Add Section
            Console.WriteLine("************************************************************");
            Console.WriteLine("\n            List - Add Section");
            Console.WriteLine("************************************************************");
            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);
                Console.Write("Press any key to add more or (e) to exit: ");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput != 'e');

            // List - Traversal Section
            Console.WriteLine("************************************************************");
            Console.WriteLine("\n          List - Traversal Section");
            Console.WriteLine("************************************************************");
            TraverseList(names);

            // List - Reverse Traversal Section
            Console.WriteLine("************************************************************");
            Console.WriteLine("\n          List - Reverse Traversal Section");
            Console.WriteLine("************************************************************");
            TraverseListReverse(names);
        }

        // Section Separator
        static void SectionSeparator(string sectionName)
        {
            Console.WriteLine($"\n---- {sectionName} ----\n");
        }

        // Character Counter
        static int CharacterCounter(char characterInput, string word)
        {
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            int count = 0;
            foreach (char c in word)
            {
                if (c == characterInput)
                    count++;
            }
            return count;
        }

        // Palindrome Checker
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return word == reversedWord;
        }

        // Traverse List
        static void TraverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Reverse Traverse List
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
