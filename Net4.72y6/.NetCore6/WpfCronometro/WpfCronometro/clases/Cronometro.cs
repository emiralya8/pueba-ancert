using System;
using System.Diagnostics;
using System.Timers;
using System.Windows.Controls;
using WpfCronometro.interfaces;
using System.Windows.Threading;
using Timer = System.Timers.Timer;
using System.Runtime.Serialization;

namespace WpfCronometro.clases
{
    public class Cronometro : ICronometro
    {
        private Timer aTimer;
        private Stopwatch stopWatch;
        private Label lblcronometro;
        public Cronometro()
        {
            stopWatch = new Stopwatch();
            aTimer = new Timer();
            aTimer.Elapsed += OnTimedEvent;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            TimeSpan tspan = stopWatch.Elapsed;

            if (!lblcronometro.Dispatcher.CheckAccess())
            {
                string str = String.Format("{0:00}::{1:00}::{2:00}",
                tspan.Hours, tspan.Minutes, tspan.Seconds);
                lblcronometro.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                UpdateUIDelegate, str);
            }
        }

        public void pause()
        {
            stopWatch.Stop();
            aTimer.Enabled = false;            
        }

        public void setLabel(Label lbl)
        {
            lblcronometro = lbl;
        }

        public void start()
        {
            stopWatch.Start();
            aTimer.Enabled = true;
        }

        public void stop()
        {
            stopWatch.Reset();
            lblcronometro.Content = String.Format("{0:00}::{1:00}::{2:00}",
                0, 0, 0);
            aTimer.Enabled = false;
        }

        private void UpdateUIDelegate(string strCronometro)
        {
            lblcronometro.Content = strCronometro;
        }

    }
}
