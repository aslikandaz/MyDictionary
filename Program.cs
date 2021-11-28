using System;

namespace OdevDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "aslı");
            myDictionary.Add(2, "halime");
            myDictionary.Add(3, "ayşe");
            myDictionary.Add(4, "fatma");
           

            Console.WriteLine(myDictionary.Length);
        }
    }
}
