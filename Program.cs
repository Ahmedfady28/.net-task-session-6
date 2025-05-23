namespace StackOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("My first post", "This is the description of my first post.");
            var post2 = new Post();

            post.UpVote();
            post.UpVote();

            post.DownVote();
            post.DownVote();

            post2.UpVote();
            post2.UpVote();
            post2.UpVote();

            post2.DownVote();
            post2.DownVote();

            //post.DownVote(); // this line will throw an exception

            Console.WriteLine(post.ToString());
            Console.WriteLine("===================================");
            Console.WriteLine(post2.ToString());
        }
    }
}
