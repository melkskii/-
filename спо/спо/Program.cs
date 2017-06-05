using System;
using System.IO;

namespace спо
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for(int i=0;i < File.ReadAllLines(@"D:\otchet.txt").Length; i++)
            {
                for(int j = 0; j < File.ReadAllLines(@"D:\otchet.txt")[i].Length; j++)
                {
                    if (File.ReadAllLines(@"D:\otchet.txt")[i][j] == '#')
                    {
                        n++;
                    }
                }
            }
            if (n >= 2) Console.WriteLine("yes"); else Console.WriteLine("no");
            Console.ReadLine();

             
        }
    }
}
