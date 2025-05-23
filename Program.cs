namespace stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(5000);
            stopwatch.Stop();


            stopwatch.Start();
            System.Threading.Thread.Sleep(5000);
            stopwatch.Stop();
        }
    }
}
