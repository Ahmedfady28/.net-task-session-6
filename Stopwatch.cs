using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{

    internal class Stopwatch : stopwatchController
    {
        private DateTime _startTime;
        public TimeSpan durationTime { get; private set; }

        private bool inProcess =false;

        public void Start()
        {
            if (inProcess)
            {
                throw new InvalidOperationException("Stopwatch is already running.");

            }
      
            Console.WriteLine("Stopwatch started...");
            _startTime = DateTime.Now;
            durationTime = TimeSpan.Zero;
            inProcess = true;
        }

        public void Stop()
        {
            if (!inProcess)
            {
                throw new InvalidOperationException("Stopwatch is not running can't stop before start run it.");
            }
            durationTime = DateTime.Now - _startTime;
            Console.WriteLine("Stopwatch stopped...");
            DisplayResult();
            inProcess = false;
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Duration result:");
            Console.WriteLine($"Houers : {durationTime.Hours}.");
            Console.WriteLine($"Min : {durationTime.Minutes}.");
            Console.WriteLine($"Sec : {durationTime.Seconds}.");

        }
    }
}
