    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Exercises
    {
        class Program
        {
            static void Main(string[] args)
            {

                List<Exercise> Exercises = new List<Exercise>();
                var inputLine = Console.ReadLine();

                while(inputLine != "go go go")
                {
                    var splitted = inputLine.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var topic = splitted[0];
                    var courseName = splitted[1];
                    var judgeLink = splitted[2];

                    List<string> problems = splitted.Skip(3).ToList();
                    Exercise currExercise = new Exercise() { Topic = topic,
                    CourseName = courseName,
                    Link = judgeLink,
                    Problems = problems};
                    Exercises.Add(currExercise);
                    inputLine = Console.ReadLine();
                }
                foreach (var exercise in Exercises)
                {
                    Console.WriteLine("Exercises: "+ exercise.Topic);
                    Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                    Console.WriteLine("Check your solutions here: {0}", exercise.Link);

                    int count = 1;
                    foreach (var problem in exercise.Problems)
                    {
                        Console.WriteLine("{0}. {1}", count, problem);
                        count++;
                    }
                }
            
            }
            class Exercise
            {
                public string Topic { get; set; }
                public string CourseName { get; set; }
                public string Link { get; set; }
                public List<string> Problems { get; set; }

            }
        }
    }
