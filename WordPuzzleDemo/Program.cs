using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WordPuzzleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****Welcome To Word Puzzle Game*****\n");
            //Console.ReadLine();

            string s = "MASTER";
            Console.WriteLine("Given Word: {0}" , s);
            Console.WriteLine("\nCreate multiple words from the letters of the given Word");
            Console.WriteLine("Read the Instructions Given Below to play Game.");
            Console.WriteLine("1. Please enter the words in uppercase.\n" +
                              "2. Every correct word will add 1 point to your score.\n" +
                              "3. In order to quit from game , type ‘QUIT’.");

            String[] str = new String[] 
            {"are","arm","ars","art","ate","ear","eat","era","set","arm","mat","met","ram","rat",
              "rem","sea","set","tea","sate","rase","mate","rest","same","seam","seat","star",
              "meta","team","tear","term","rest"};

            string str1= s;

            Console.Write("-----------------------------------\n");
            Console.Write("Input the string : ");

            for (int i =0; i<= s.Length; i++) 
            {
                str1 = s[i].ToString();
            }
            if (str1 == s) 
            {
                Console.WriteLine("Correct" );
            }
           
            else
            {
                Console.WriteLine("Incorrect");
            }




            Console.ReadKey();




        }
    }
}
