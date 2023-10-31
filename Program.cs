using System;
using System.Threading;

class Program
{
    // To track if the stopwatch is running
    static bool isRunning = false;

    // Variable to store the elapsed time
    static TimeSpan elapsedTime = TimeSpan.Zero;

    static void Main(string[] args)
    {
        Console.WriteLine("Stopwatch Timer");

        // infinite loop to continuosly display the timer and process user input
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Time: " + elapsedTime.ToString("hh\\:mm\\:ss"));
            Console.WriteLine("Commands:");
            Console.WriteLine("S - Start");
            Console.WriteLine("P - Pause");
            Console.WriteLine("R - Resume");
            Console.WriteLine("E - Reset");
            Console.WriteLine("Q - Quit");

            // REads character input from the user
            char input = Console.ReadKey(true).KeyChar;

            HandleInput(input);
        }
    }

    // Handles user input by processing the provided char
    static void HandleInput(char input)
    {
        switch (char.ToUpper(input))
        {
            // Starts stop watch if it's not already running
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
                }
                break;
            case 'R':
                if (!isRunning)
                {
                    isRunning = true;
                    StartStopwatch();
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

    // increments the elapsed time by one second as long as is running is set to true
    static void StartStopwatch()
    {
        while (isRunning)
        {
            Thread.Sleep(1000);
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
        }
    }
    // Resets the stopwatch by stopping it and resetting the elapsed time to zero
    static void ResetStopwatch()
    {
        isRunning = false;
        elapsedTime = TimeSpan.Zero;
    }
}
