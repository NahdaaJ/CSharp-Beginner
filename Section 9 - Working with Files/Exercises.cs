using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Section_9___Working_with_Files
{
    internal class Exercises
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write a program that reads a text file and displays the number of words.
            var filePath = "C:\\Users\\Nahdaa\\Documents\\C# Beginner\\Section 9 - Working with Files\\Text.txt";

            var numWords = NumberOfWords(filePath, "\n");
            Console.WriteLine(numWords);

            // Exercise 2
            // Write a program that reads a text and displays the longest word in the file.
            var longestWord = LongestWord(filePath, "\n");
            Console.WriteLine("The longest word in the file is: "+longestWord);


        }

        public static int NumberOfWords(string path, string split)
        {
            var content = File.ReadAllText(path);
            var wordsList = content.Split(split);//Splitting the file by the specified splitter.
            return wordsList.Length; // Returns length of the string = number of words.
        }

        public static string LongestWord(string path, string split)
        {
            var content = File.ReadAllText(path);
            var wordsList = content.Split(split); // Splitting the file by the specified splitter.

            int i = 1;
            string longWord = "";
            foreach (var word in wordsList)
            {
                if (word.Length > wordsList[i].Length) // whichever has the longest length is set as longWord.
                    longWord = word;
                else
                    longWord = wordsList[i];
                if (i == wordsList.Length - 1) // Breaking the loop so i doesnt go past the list bounds.
                    break;
                i++;
            }
            return longWord; // return the longest word.
        }
    }
}
