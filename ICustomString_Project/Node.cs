using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class Node
    {
        public string data;
        public Node next;

        

        public Node (string data)
        {
            this.data = data;
            this.next = null;

            
        }

        public void Print()
        {
            Console.Write("|" +data+ "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void Insert(string data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.Insert(data);
            }
        }



    }
}
