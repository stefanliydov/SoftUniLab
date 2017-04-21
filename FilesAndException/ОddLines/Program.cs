using System;
using System.IO;

namespace ОddLines
{
    class Program
    {
        static void Main(string[] args)
        {


            var textLines = File.ReadAllLines("myfile.txt");
            
            if (!File.Exists("result.txt"))
                File.Create("result.txt");
            var currLine = string.Empty;
            for (int i = 0; i < textLines.Length; i++)
            {
                 currLine = i+1+"."+" "+textLines[i] + Environment.NewLine;
                File.AppendAllText("result.txt", currLine  );
            }
            Console.WriteLine(File.ReadAllText("result.txt"));
            File.WriteAllText("result.txt", string.Empty);

        }
    }
}
