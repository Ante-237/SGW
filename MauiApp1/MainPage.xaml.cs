using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using Microsoft.Maui.Controls;



namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private static Stopwatch _stopWatch;
        private static bool isRunning = false;
    


        public MainPage()
        {
            _stopWatch = new Stopwatch();
            InitializeComponent();
            SetupUpdateTimer();
        }
        
        private void SetupUpdateTimer()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {

                if (isRunning)
                {
                    TimerLabel.Text = $"{_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}";
                    SemanticScreenReader.Announce(TimerLabel.Text);
                }

           


                return true;
            });
        }
        


        private void OnStartClicked(object sender, EventArgs e)
        {
            count++;
            TimerLabel.Text = $"{_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}";
            _stopWatch.Start();
            isRunning = true;
            SemanticScreenReader.Announce(TimerLabel.Text);
            StateLabel.Text = "Timer Started";
        }

        private void OnPauseClicked(object sender, EventArgs e)
        {
            count++;
         
            TimerLabel.Text = $"{_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}";
            isRunning = false;
            StateLabel.Text = "Timer Paused";
            _stopWatch.Stop();
            SemanticScreenReader.Announce(TimerLabel.Text);
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            count = 0;
           
            _stopWatch.Reset();
            TimerLabel.Text = $"{_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}";
            StateLabel.Text = "Timer Reset";
            SemanticScreenReader.Announce(TimerLabel.Text);
        }

        private void OnStopClicked(object sender, EventArgs e)
        {
             count++;
            _stopWatch.Stop();
            TimerLabel.Text = $"{_stopWatch.Elapsed.ToString("hh\\:mm\\:ss")}";
            StateLabel.Text = "Stoped Timer";
            SemanticScreenReader.Announce(TimerLabel.Text);
        }
    }
}