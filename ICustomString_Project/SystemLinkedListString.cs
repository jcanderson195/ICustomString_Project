using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class SystemLinkedListString : ICustomString
    {
        
        

        public LinkedList<string> newLinkedList;

        public string firstNode = "J";

        public SystemLinkedListString()
        {
           
            
            newLinkedList = new LinkedList<string>();
        }
        

        public override string ToString()
        {
            newLinkedList.AddFirst(firstNode);
            newLinkedList.AddLast("C");
            newLinkedList.AddLast("A");

            foreach(string character in newLinkedList)
            {
                Console.Write("|"+character+"|->");
            }

            return "Linked List" + newLinkedList;

        }

        

        public void Insert(string stringToInsert)
        {

            LinkedListNode<string> node = newLinkedList.Find(firstNode);
            newLinkedList.AddAfter(node, stringToInsert);

            foreach (string character in newLinkedList)
            {
                Console.Write("|" + character + "|->");
            }

        }

        public int Length()
        {

            Console.WriteLine(newLinkedList.Count);
            return newLinkedList.Count;
            
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            
            newLinkedList.RemoveLast();

            foreach (String character in newLinkedList)
            {
                Console.Write("|" + character + "|->");
            }
        }
    }
}
