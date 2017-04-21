using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class User
    {
        public string Username { get; set; }
        public List<string> ReceivedMessages { get; set; }

    }
    class Message
    {
        public string Content { get; set; }
        public string Sender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
