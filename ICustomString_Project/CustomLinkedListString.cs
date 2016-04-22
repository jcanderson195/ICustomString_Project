using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class CustomLinkedListString : ICustomString
    {

        MyList list = new MyList();

        public override string ToString()
        {
            
            list.AddToEnd("J");
            list.AddToEnd("S");
            list.AddToEnd("T");

            list.Print();

            return "New Custom Linked List: " + list;
        }

        public void Insert(string stringToInsert)
        {
            list.AddToEnd(stringToInsert);
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
