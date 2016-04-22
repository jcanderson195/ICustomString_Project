using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class SystemLinkedListString : ICustomString
    {
        
        public Node headNode;

        public LinkedList<string> newLinkedList;

        public SystemLinkedListString()
        {
            headNode = null;
            
            newLinkedList = new LinkedList<string>();
        }
        

        public override string ToString()
        {
            AddToEnd("J");
            AddToEnd("S");
            AddToEnd("T");

            if (headNode != null)
            {
                headNode.Print();
            }

            
            return "Linked List: "+headNode;
        }

        public void AddToEnd(string data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.Insert(data);
            }
        }

        public void Insert(string stringToInsert)
        {


            headNode.Insert(stringToInsert);
            

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
