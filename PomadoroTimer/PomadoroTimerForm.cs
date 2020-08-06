using System;
using System.Timers;
using System.Windows.Forms;

namespace PomadoroTimer
{

    public partial class PomadoroForm : Form
    {
        public PomadoroForm()
        {
            InitializeComponent();
        }

        private static System.Timers.Timer pomTimer;
        private static System.Timers.Timer breakTimer;

        private void SetPomTimer()
        {
            //Construct timer with one second interval
            pomTimer = new System.Timers.Timer(1000);
            //hook-up event handler method
            pomTimer.Elapsed += PomTimerElapsedEvent;
            pomTimer.AutoReset = true;
            pomTimer.Enabled = true;
        }

        private void SetBreakTimer()
        {
            //Construct timer with one second interval
            breakTimer = new System.Timers.Timer(1000);
            //hook-up event handler method
            breakTimer.Elapsed += BreakTimerElapsedEvent;
            breakTimer.AutoReset = true;
            breakTimer.Enabled = true;
        }

        private void BreakTimerElapsedEvent(object sender, ElapsedEventArgs e)
        {
            TbBreakTime.Text = $"{e.SignalTime}";
        }

        private void PomTimerElapsedEvent(object sender, ElapsedEventArgs e)
        {
            TbPomTime.Text = $"{e.SignalTime}";
        }

        private void BtnStartPom_Click(object sender, EventArgs e)
        {
            SetPomTimer();
            
        }
    }
}
