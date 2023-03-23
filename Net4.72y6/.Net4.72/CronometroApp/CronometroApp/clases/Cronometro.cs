using CronometroApp.interfaces;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace CronometroApp.clases
{
    public class Cronometro : ICronometro
    {
        private Stopwatch stwatch;
        private Timer timer;
        private Label lblcronometro;
        public Cronometro()
        {
            stwatch = new Stopwatch();
            timer = new Timer();
            timer.Tick += myTimer_Tick_Event;
        }

        private void myTimer_Tick_Event(object sender, EventArgs e)
        {
            TimeSpan tspan = stwatch.Elapsed;

            lblcronometro.Text = String.Format("{0:00}::{1:00}::{2:00}",
                tspan.Hours, tspan.Minutes, tspan.Seconds);
        }

        public void Pause()
        {
            stwatch.Stop();
            timer.Enabled = false;
        }

        public void Start()
        {
            stwatch.Start();
            timer.Enabled = true;
        }

        public void Stop()
        {
            stwatch.Reset();
            timer.Enabled = false;
            lblcronometro.Text = String.Format("{0:00}::{1:00}::{2:00}",
                0, 0, 0);
        }

        public void setLabel(Label lbl)
        {
            lblcronometro = lbl;
        }

        public Label getLabel()
        {
            return lblcronometro;
        }
    }
}
