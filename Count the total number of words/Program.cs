using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_total_number_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string words ;
            int word = 0;
            Console.Write("Input Words : ");
            words = Console.ReadLine();
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == ' ')
                {
                    word++;
                }
            }
            Console.WriteLine("Total Words Are : " + ++word);
        }
    }
}
