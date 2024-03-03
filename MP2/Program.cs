using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAO_BingoCardGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nBINGO CARDS GENERATOR\n");

            Console.ResetColor();
            Console.WriteLine("How many bingo cards do you want to get?");
            int uinput = int.Parse(Console.ReadLine());
            int min = 1; int max = 10;

            BingoCardGenerator(uinput);
        }

        public static void RandomGenerateNumber()
        {
            int[] arr = new int[24];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 75);
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }

        public static void BingoCardGenerator(int b)
        {

            for (int x = 0; x < b; x++)
            { Console.WriteLine("-------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" B " + "|" + " I " + "|" + " N " + "|" + " G " + "|" + " O ");
                Console.ResetColor();
                Console.WriteLine("-------------------");
                Console.WriteLine();
            }
        }
    }

}




