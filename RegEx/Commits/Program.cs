using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Commits
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex(@"https:\/\/github.com\/(?<user>[A-Za-z1-9-]*)\/(?<repo>[A-Za-z-_]*)\/commit\/(?<commit>[a-f0-9]{40}),(?<message>[^\n]*),(?<add>[0-9]*),(?<del>[0-9]*)");

            var command = Console.ReadLine();
            SortedDictionary<string, SortedDictionary<string, List<Commit>>> userDict = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while (command != "git push")
            {
                if (regex.IsMatch(command) == true)
                {
                    var match = regex.Match(command);
           
                    Commit currCommit = new Commit()
                    {
                        Hash = match.Groups["commit"].Value,
                        Message = match.Groups["message"].Value,
                        Add = match.Groups["add"].Value,
                        Del = match.Groups["del"].Value
                    };

                    var repo = match.Groups["repo"].Value;
                    var user = match.Groups["user"].Value;

                    if (!userDict.ContainsKey(user))
                    { userDict[user] = new SortedDictionary<string, List<Commit>>(); }
                    if (!userDict[user].ContainsKey(repo))
                        userDict[user][repo] = new List<Commit>();
                    userDict[user][repo].Add(currCommit);

                    
                }
                command = Console.ReadLine();
            }

                foreach (var user in userDict)
                {
                var add = 0;
                var del = 0;
                    Console.WriteLine(user.Key + ":");
                    foreach (var repos in user.Value)
                    {
                        Console.WriteLine("  " + repos.Key + ":");
                        foreach (var commit in repos.Value)
                        {
                            Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Add} additions, {commit.Del} deletions)");
                        add += int.Parse(commit.Add);
                        del += int.Parse(commit.Del);
                        }
                         
                    }
                Console.WriteLine($"    Total: {add} additions, {del} deletions");
                }

        }
        class Commit
        {

            public string Hash { get; set; }
            public string Message { get; set; }
            public string Add { get; set; }
            public string Del { get; set; }


        }
    }
}
