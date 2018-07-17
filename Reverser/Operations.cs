using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public class Operations
    {
        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            string output = String.Join(" ", words);
            return output;
        }

        public static string ReverseLettersInEachWord(string str)
        {
            List<string> reversedWords = new List<string>();

            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                string reversedWord = new string(letters);
                reversedWords.Add(reversedWord);
            }

            string reversedSentence = String.Join(" ", reversedWords.ToArray());
            return reversedSentence;
        }
    }
}
