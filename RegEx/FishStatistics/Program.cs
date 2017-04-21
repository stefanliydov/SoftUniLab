using System;
using System.Text.RegularExpressions;

namespace FishStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(?<tail>>*)<(?<body>\(*)(?<eye>['-x])>";
            var regex = new Regex(pattern);
            var matchTest = regex.IsMatch(input);
            if (matchTest == false)
                Console.WriteLine("No fish found.");
            else
            {
                var matches = regex.Matches(input);
                var count = 1;
                foreach (Match match in matches)
                {
                    var tail = match.Groups["tail"].Value;
                    var body = match.Groups["body"].Value;
                    var eye = match.Groups["eye"].Value;

                    var tailSize = "";
                    var bodySize = "";
                    var status = "";

                    if (tail.Length > 5)
                        tailSize = "Long";
                    else if (tail.Length > 1)
                        tailSize = "Medium";
                    else if (tail.Length == 1)
                        tailSize = "Short";
                    else if(tail.Length == 0)
                        tailSize = "None";

                    if (body.Length > 10)
                        bodySize = "Long";
                    else if (body.Length > 5)
                        bodySize = "Medium";
                    else if(body.Length>1)
                        bodySize = "Short";

                    if (eye == "\'")
                        status = "Awake";
                    else if (eye == "-")
                        status = "Asleep";
                    else if (eye == "x")
                        status = "Dead";

                    Console.WriteLine($"Fish {count}: " + match.Value);
                    if (tailSize == "None")
                        Console.WriteLine($"  Tail type: {tailSize}");
                    else
                        Console.WriteLine($"  Tail type: {tailSize} ({tail.Length * 2} cm)");
                    Console.WriteLine($"  Body type: {bodySize} ({body.Length * 2} cm)");
                    Console.WriteLine($"  Status: {status}");

                    count++;
                }
            }
            


        }
    }
}
