using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

class Program
{
    static Stopwatch stopwatch = new Stopwatch();
    static bool isRunning = false;
    static bool stopRequested = false;
    static System.Timers.Timer timer;

    static void Main(string[] args)
    {
        Console.WriteLine("Stopwatch Timer");
        timer = new System.Timers.Timer(1000); // Create a timer to update the time every second
        timer.Elapsed += TimerElapsed;

        while (true)
        {
            Console.Clear();
            DisplayTime();

            if (!isRunning)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("S - Start");
                Console.WriteLine("P - Pause");
                Console.WriteLine("R - Resume");
                Console.WriteLine("E - Reset");
                Console.WriteLine("Q - Quit");
            }
            else
            {
                Console.WriteLine("Press P to pause");
            }

            char input = Console.ReadKey(true).KeyChar;
            HandleInput(input);
        }
    }

    static void DisplayTime()
    {
        Console.WriteLine("Time: " + stopwatch.Elapsed.ToString("hh\\:mm\\:ss"));
    }

    static void HandleInput(char input)
    {
        switch (char.ToUpper(input))
        {
            case 'S':
                if (!isRunning)
                {
                    isRunning = true;
                    StartStopwatch();
                }
                break;
            case 'P':
                if (isRunning)
                {
                    isRunning = false;
                    PauseStopwatch();
                }
                break;
            case 'R':
                if (!isRunning)
                {
                    isRunning = true;
                    ResumeStopwatch();
                }
                break;
            case 'E':
                ResetStopwatch();
                break;
            case 'Q':
                Environment.Exit(0);
                break;
        }
    }

    static void StartStopwatch()
    {
        stopwatch.Start();
        timer.Start();
    }

    static void PauseStopwatch()
    {
        if (isRunning)
        {
            isRunning = false;
            stopRequested = true;
            stopwatch.Stop();
            timer.Stop();
        }
    }

    static void ResumeStopwatch()
    {
        if (!isRunning)
        {
            isRunning = true;
            stopRequested = false;
            stopwatch.Start();
            timer.Start();
        }
    }

    static void ResetStopwatch()
    {
        isRunning = false;
        stopRequested = true;
        stopwatch.Reset();
        timer.Stop();
    }

    static void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        if (isRunning)
        {
            Console.Clear();
            DisplayTime();
        }
    }
}
