using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class SystemArrayString : ICustomString
    {

        public string[] newArray = { "J", "J","T"};
        

        public override string ToString()
        {

            foreach(String characters in newArray)
            {
                Console.WriteLine(characters);
            }
            return "New array:" +newArray;
        }

        public void Insert(string stringToInsert)
        {
            Array.Resize<string>(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = stringToInsert;

            foreach(String character in newArray)
            {
                Console.WriteLine(character);
            }
        }

        public int Length()
        {
            Console.WriteLine(newArray.Length);
            return newArray.Length;
        }


        public void Remove(int startIndex, int numCharsToRemove)
        {
            
            Array.Resize(ref newArray, numCharsToRemove);
            newArray[newArray.Length -1] = " ";

            foreach (String charcters in newArray)
            {
                Console.WriteLine(charcters);
            }
             
        }

        }
    }

