using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class Node
    {
        public int data;
        public Node next;

        List<string> list;

        public Node (int data)
        {
            this.data = data;
            this.next = null;

            list = new List<string>();
        }


    }
}
