using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class SystemString : ICustomString
    {

        public string word {get; set;}
        public string newInsertWord { get; set;}

        public override string ToString()
        {
            return "New word:" + word;
        }

        public void Insert(string stringToInsert)
        {
            newInsertWord = stringToInsert;
            Console.WriteLine("The original string: '{0}'",newInsertWord);
            string modified = newInsertWord.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);
        }

        public int Length()
        {
            Console.WriteLine("Enter a word to get the length of it.");
            Console.WriteLine("--------------------");
            string wordForLength = Console.ReadLine();
            Console.WriteLine(wordForLength.Length);
            return wordForLength.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Console.WriteLine("Enter 7 characters to test remove function");
            Console.WriteLine("----------------------------");
            string digits = Console.ReadLine();
            Console.WriteLine(digits);
            string modified = digits.Remove(startIndex, numCharsToRemove);
            Console.WriteLine(modified);
            
        }
    }
}
