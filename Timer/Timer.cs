using System;
using System.Diagnostics;
using System.Threading;



namespace WatchStuff{

    public class Watch{

        /// <summary>
        /// holds reference to the stop watch
        /// </summary>
        private static Stopwatch _stopWatch;

        /// <summary>
        /// represents the active state of the application
        /// </summary>
        public static bool isRunning = false;

        
/// <summary>
/// Manages main logic of the stop watch.
/// </summary>
        public static void Main(){

         _stopWatch  = new Stopwatch();
         Entry();

         while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.S:
                            StartButton();
                            break;
                        case ConsoleKey.F:
                            StopButton();
                            break;
                        case ConsoleKey.R:
                            ResumeButton();
                            break;
                        case ConsoleKey.Z:
                            ResetButton();
                            break;
                        case ConsoleKey.P:
                            PauseButton();
                            break;
                        case ConsoleKey.Escape:
                            return; 
                    }
                }

                if (isRunning)
                {
                    Console.Clear();
                    Entry();
                    Console.WriteLine($"\n\t\t\tCURRENT TIME : {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");  
                    Thread.Sleep(200);
                }
            }

        }

/// <summary>
/// Default call method for showing instructions
/// </summary>
        public static void Entry(){ 
            DefaultInstruction();
          
        }
/// <summary>
/// Show instructinos for buttons
/// </summary>
        public static void DefaultInstruction(){
            Console.WriteLine("\n\n\t\t\tSTOPWATCH CONTROLS\n\n [S] == START  |  [P] == PAUSE  |  [R] == RESUME  |  [Z] == RESET  |  [F] == STOP |  [Esc] == EXIT");
        }

/// <summary>
/// The start button starts the watch from the secs and adds up to minutes and hours
/// </summary>
        public static void StartButton(){
            if (!isRunning)
            {
                _stopWatch.Start();
                isRunning = true;
                DefaultInstruction();
                Console.WriteLine($"\n\t\t\tSTARTED {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");
            }                 
        }

/// <summary>
/// The pause button pauses the stopwatch and prints its current value to the console or display the current value
/// </summary>
        public static void PauseButton(){
                // P to pause
            if (isRunning)
            {
                _stopWatch.Stop();
                isRunning = false;
                DefaultInstruction();
                Console.WriteLine($"\n\t\t\tPAUSED {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");
            }     
        }

/// <summary>
/// The resume button continues the stopwatch from when it was paused
/// </summary>
        public static void ResumeButton(){
                if (!isRunning)
            {
                _stopWatch.Start();
                isRunning = true;
                DefaultInstruction();
                Console.WriteLine($"\n\t\t\tRESUMED {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");
            }     
        }

/// <summary>
/// The reset button setS the watch back to 00:00:00
/// </summary>
        public static void ResetButton(){
            _stopWatch.Reset();
            isRunning = false;
            DefaultInstruction();
            Console.WriteLine($"\n\t\t\tRESET {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");
        }

/// <summary>
/// The stopbutton stops the watch and display the last read value
/// </summary>
        public static void StopButton(){
            if (isRunning)
                {
                    _stopWatch.Stop();
                    PauseButton();
                    isRunning = false;
                    Entry();
                    Console.WriteLine($"\n\t\t\tSTOPPED {_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}");
                }
        }

    }

}
