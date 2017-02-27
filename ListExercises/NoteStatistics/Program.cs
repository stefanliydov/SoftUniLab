using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();
            var noteList = new List<string>();
            var naturalList = new List<string>();
            var sharpList = new List<string>();
            var natSum = 0.00;
            var sharpSum = 0.00;



            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "261.63":noteList.Add("C");naturalList.Add("C");natSum += double.Parse(list[i]);break;
                    case "293.66": noteList.Add("D"); naturalList.Add("D"); natSum += double.Parse(list[i]); break;
                    case "329.63": noteList.Add("E"); naturalList.Add("E"); natSum += double.Parse(list[i]); break;
                    case "349.23": noteList.Add("F"); naturalList.Add("F"); natSum += double.Parse(list[i]); break;
                    case "392.0": noteList.Add("G"); naturalList.Add("G"); natSum += double.Parse(list[i]); break;
                    case "440.0": noteList.Add("A"); naturalList.Add("A"); natSum += double.Parse(list[i]); break;
                    case "493.88": noteList.Add("B"); naturalList.Add("B"); natSum += double.Parse(list[i]); break;
                    case "277.18": noteList.Add("C#"); sharpList.Add("C#"); sharpSum += double.Parse(list[i]); break;
                    case "311.13": noteList.Add("D#"); sharpList.Add("D#"); sharpSum += double.Parse(list[i]); break;
                    case "369.99": noteList.Add("F#"); sharpList.Add("F#"); sharpSum += double.Parse(list[i]); break;
                    case "415.30": noteList.Add("G#"); sharpList.Add("G#"); sharpSum += double.Parse(list[i]); break;
                    case "466.16": noteList.Add("A#"); sharpList.Add("A#"); sharpSum += double.Parse(list[i]); break;

                }
           

            }
            Console.WriteLine("Notes: " + string.Join(" ", noteList));
            Console.WriteLine("Naturals: " + string.Join(", ", naturalList));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpList));
            Console.WriteLine("Naturals sum: {0}", natSum);
            Console.WriteLine("Sharps sum: {0}", sharpSum);
        }
    }
}
