using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomString_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            SystemString word = new SystemString { word = "John" };
            Console.WriteLine(word);
            word.Insert("Hello");
            word.Length();
            word.Remove(0, 3);

            SystemArrayString newTest = new SystemArrayString();
            newTest.ToString();
            Console.WriteLine("-----------");
            newTest.Insert("K");
            newTest.Length();
            Console.WriteLine("---------------");
            newTest.Remove(0, 5);

            SystemLinkedListString testing = new SystemLinkedListString();
            testing.ToString();
            Console.WriteLine("------------");
            testing.Insert("T");
            Console.WriteLine("-------------");
            testing.Length();
            Console.WriteLine("-------------");
            testing.Remove(0, 4);

            CustomLinkedListString custom = new CustomLinkedListString();
            custom.ToString();

            Console.ReadKey();
        }
    }
}
