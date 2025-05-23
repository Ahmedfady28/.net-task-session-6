using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Post : Votable
    {
        public string title;
        public string desc;
        public int voteCount { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Post(string title, string desc)
        {
            this.title = title;
            this.desc = desc;
            voteCount = 0;
            CreatedAt = DateTime.Now;
        }

        public Post()
        {
            title = "No title";
            desc = "No description";
            voteCount = 0;
            CreatedAt = DateTime.Now;
        }
        public void UpVote()
        {
            voteCount++;
        }
        public void DownVote()
        {
            if (voteCount <= 0)
            {
                throw new InvalidOperationException("Vote count cannot be negative.");
            }

            voteCount--;
        }


        public override string ToString()
        {
            return $"Title: {title}, Description: {desc}, Vote Count: {voteCount}, Created At: {CreatedAt}";
        }

    }
}
