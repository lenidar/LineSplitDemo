using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineSplitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string thing = "The quick brown fox jumps over the lazy dog       ";
            string[] words = thing.Split(' ');

            Console.WriteLine(words.Length);

            foreach(string word in words) 
            {
                Console.Write("\"");
                Console.Write(word);
                Console.WriteLine("\"");
            }

            Console.ReadKey();
        }
    }
}
