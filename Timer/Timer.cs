using System;
using System.Timers;




namespace StopWatch{

    public class Timer{

        private static Timer _time;

        public static void Main(){
           Entry();

        }

        public static void Entry(){
            _time = new Timer();
            
             Console.WriteLine("\n\n\t\t\tSTOPWATCH CONTROLS\n\n [S] == START  |  [P] == PAUSE  |  [R] == RESUME  |  [Z] == RESET  |  [F] == STOP");
             Console.WriteLine("\n\t\t\tCURRENT TIME : {0:HH:mm:ss}", DateTime.Now);
        }


        public static void StartButton(){
                // S to start
        }

        public static void PauseButton(){
                // P to pause
        }

        public static void ResumeButton(){
                // R to resume
        }

        public static void ResetButton(){
                // Z to reset
        }

        public static void StopButton(){
                // F to stop
        }

    }

}
