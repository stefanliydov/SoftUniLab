using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            var command = Console.ReadLine().Split();

            while (string.Join(" ", command) != "drop the media")
            {

                if( command[0] == "post")
                {
                    if (!dict.ContainsKey(command[0]))
                    {
                        var dictList = new Dictionary<string, List<string>>();
                        dict[command[1]] = dictList;
                    }
                }
                else if (command[0] == "like")
                {
                    if (!dict[command[1]].ContainsKey("Like"))
                        dict[command[1]]["Like"] = new List<string> ();

                    dict[command[1]]["Like"].Add("1");
                }
                else if (command[0] == "dislike")
                {
                    if (!dict[command[1]].ContainsKey("Dislike"))
                        dict[command[1]]["Dislike"] = new List<string>();

                    dict[command[1]]["Dislike"].Add("1");
                }
                else if(command[0] == "comment")
                {
                    string comment = string.Empty;
                    for (int i = 3; i < command.Length; i++)
                    {
                        comment += command[i] + " ";
                    }
                    if (!dict[command[1]].ContainsKey(command[2]))
                        dict[command[1]][command[2]] = new List<string>();

                    dict[command[1]][command[2]].Add(comment);
                }

                command = Console.ReadLine().Split();
            }
            var commentsDict = new Dictionary<string, string>();
            foreach (var post in dict)
            {
                var postName = post.Key;
                var likes = 0;
                var dislikes = 0;
                var typeOfToken = post.Value;
                foreach (var postType in typeOfToken)
                {
                    if(postType.Key == "Like")
                    {
                       likes= postType.Value.Select(int.Parse).Sum();
                    }
                    else if (postType.Key == "Dislike")
                    {
                       dislikes= postType.Value.Select(int.Parse).Sum();
                    }
                    else
                    {
                        commentsDict[postType.Key] = string.Join(" ", postType.Value);
                    }
                                   
                }
                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments: ");
                if (commentsDict.Count == 0)
                    Console.WriteLine("None");

                else
                {
                    foreach (var item in commentsDict)
                    {
                        Console.WriteLine($"*  {item.Key}: {item.Value}");
                    }
                }
                commentsDict.Clear();
            }
        }
    }
}
