using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaFisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsread = File.Open(@"c:\temp\fisierul1.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fsread);


            string firstLine = sr.ReadLine();
            Console.WriteLine(firstLine);

            string[] tokens = firstLine.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            Console.Write(sum);
            Console.WriteLine();

            string allText = string.Empty;
          
            while (!sr.EndOfStream)
            {
                allText = sr.ReadLine();
                Console.WriteLine(allText);

            }

            FileStream fs = File.OpenWrite(@"c:\temp\fisierul2.txt");
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(sum);
            sw.WriteLine(allText);
            sw.Close();

            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}
