using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DailyChallenge237
{
    class Program
    {



        const string wordListPath = @"C:\Users\rcavallaro\Documents\enable1.txt";

        static void Main()
        {
            Console.WriteLine(GetLongestWord(wordListPath, "hjklo"));
            Console.ReadKey();

        }

        static string GetLongestWord(string path, string letters)
        {
            var wordList = new List<string>();
            var wordFile = File.ReadAllLines(path);
            var letterArray = letters.ToCharArray();
            string longestWord = null;
            

            foreach (var word in wordFile) {
                var wordArray = word.ToCharArray();
                if (wordArray.Except(letterArray).Any() == false && (longestWord == null || word.Length > longestWord.Length)) {
                    longestWord = word;
                }
            }
            if (longestWord != null) {
                return longestWord;
            }
            else {
                return "NO MATCHES.";
            }
        }

        static List<string> ReadAllWords(string path)
        {
            var wordList = new List<string>();
            var wordFile = File.ReadAllLines(path);

            foreach (var w in wordFile) {
                wordList.Add(w);
            }

            return wordList;
        }

        //static string GetLongestWord(List<string> wordList)
        //{
        //}

    }
}

