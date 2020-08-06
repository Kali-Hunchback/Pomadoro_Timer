using System;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.

namespace PomadoroTimer
{

    public partial class PomadoroForm : Form
    {
        public PomadoroForm()
        {
            InitializeComponent();
        }
        //delegate intialized to enable "safe text" removing exeptions and issues with cross thread callbacks
        private delegate void SafeCallDelegate(string text);

        private static System.Timers.Timer pomTimer;
        private static System.Timers.Timer breakTimer;

        //Method checks for cross threading issues and if required, runs an invoke method using the SafeCallDelegate
        private void WriteTextSafe(string text)
        {
            if (TbPomTime.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                TbPomTime.Invoke(d, new object[] { text });
            }
            else
            {
                TbPomTime.Text = text;
            }
        }

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
            WriteTextSafe($"{e.SignalTime}");
        }

        private void BtnStartPom_Click(object sender, EventArgs e)
        {
            SetPomTimer();
            
        }
    }
}
