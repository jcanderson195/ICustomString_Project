using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class SystemLinkedListString : ICustomString
    {

        

        public LinkedList<string> newLinkedList = new LinkedList<string>();

        public override string ToString()
        {
            newLinkedList.AddLast("T");
            newLinkedList.AddLast("S");
            newLinkedList.AddLast("U");
            newLinkedList.AddFirst("J");

            foreach(String character in newLinkedList)
            {
                Console.WriteLine(character.ToString());
            }

            return "Item in LinkedList:  "+ newLinkedList.ToString();
            

        }

        public void Insert(string stringToInsert)
        {
            
            LinkedListNode<string> node = newLinkedList.Find("S");
            newLinkedList.AddAfter(node, stringToInsert);

            foreach(String character in newLinkedList)
            {
                Console.WriteLine(character);
            }
        }

        public int Length()
        {
            int value = newLinkedList.Count;
            Console.WriteLine(value);

            return value;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            newLinkedList.RemoveLast();

            foreach (String character in newLinkedList)
            {
                Console.WriteLine(character);
            }
        }
    }
}
