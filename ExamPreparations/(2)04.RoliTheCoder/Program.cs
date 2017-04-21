using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2_04.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = Console.ReadLine();

            Dictionary<int, Event> eventDict = new Dictionary<int, Event>();
            Regex validTest = new Regex(@"(?<id>\d+)\s+#(?<name>[\w\d]+)(\s+(?:@\w+\s*)+)?");

            while (events != "Time for Code")
            {
                if (validTest.IsMatch(events))
                {
                    var parts = validTest.Match(events);
                    var id = int.Parse(parts.Groups["id"].Value);
                    var name = parts.Groups["name"].Value;

                    var participants = new List<string>();

                    var partcipantsExist = events.Contains("@");
                    if (partcipantsExist)
                    {
                        participants = events.Substring(events.IndexOf('@')).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();                      
                    }

                    if (!eventDict.ContainsKey(id))
                    {
                        Event currEvent = new Event() { Name = name, Participants = participants };

                        eventDict.Add(id, currEvent);
                    }
                    else
                    {
                        if (eventDict[id].Name == name)
                        {
                            var currList = eventDict[id].Participants.ToList();
                            currList.AddRange(participants);
                            currList = currList.Distinct().ToList();
                            currList.Sort();
                            eventDict[id].Participants = currList;
                        }
                    }

                }
                events = Console.ReadLine();
            }

            eventDict = eventDict.OrderByDescending(v => v.Value.Participants.Count())
             .ThenBy(v => v.Value.Name)
             .ToDictionary(x => x.Key, x => x.Value);

            foreach (var @event in eventDict)
            {
                Console.WriteLine($"{@event.Value.Name} - {@event.Value.Participants.Count}");
                foreach (var participant in @event.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine("" + participant);
                }
            }


        }
        class Event
        {
            public string Name { get; set; }
            public List<string> Participants { get; set; }
        }
    }
}