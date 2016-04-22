using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class MyList
    {

        public Node headNode;

        public MyList()
        {
            headNode = null;
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

        public void AddToBeginning(string data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }



    }
}
