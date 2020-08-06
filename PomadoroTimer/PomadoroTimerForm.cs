using System;
using System.Windows.Forms;
using System.Media;


namespace PomadoroTimer
{
    public partial class PomadoroForm : Form
    {
        public PomadoroForm()
        {
            InitializeComponent();
        }
  
        static System.Windows.Forms.Timer pomTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer breakTimer = new System.Windows.Forms.Timer();

        public void EnableButtons() 
        {
            BtnStartBreak.Enabled = true;
            BtnStartPom.Enabled = true;
        }

        public void DisableButtons() 
        {
            BtnStartBreak.Enabled = false;
            BtnStartPom.Enabled = false;
        }

        //Event handler for pomTimer.OnTick
        private void TimerEventProcessorPom(Object myObject, EventArgs myEventArgs)
        {
            pomTimer.Stop();
            //prompt user via system sound and message box
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You've completed your Pomadoro", "Pomadoro Completed.", MessageBoxButtons.OK);
            //Disassociate the event handler created by BtbStartPom_Click
            //Done in order to make sure user is only prompted once on concurrent pomadoro completions.
            pomTimer.Tick -= TimerEventProcessorPom;
            TbPomTime.Text = "Inactive";
            EnableButtons();
        }

        private void TimerEventProcessorBreak(Object myObject, EventArgs myEventArgs)
        {
            breakTimer.Stop();
            //prompt user via system sound and message box
            SystemSounds.Hand.Play();
            MessageBox.Show("You've completed your break", "Break Completed.", MessageBoxButtons.OK);
            //Disassociate the event handler created by BtbStartBreak_Click
            //Done in order to make sure user is only prompted once on concurrent pomadoro completions.
            breakTimer.Tick -= TimerEventProcessorBreak;
            TbBreakTime.Text = "Inactive";
            EnableButtons();
        }

        //Start pomadoro, timer is set to 25 minutes
        private void BtnStartPom_Click(object sender, EventArgs e)
        {
            EventHandler handler = new EventHandler(TimerEventProcessorPom);
            pomTimer.Tick += handler;
            pomTimer.Interval = 1500000;
            pomTimer.Start();
            TbPomTime.Text = "Active";
            DisableButtons();
        }
        //Start break, timer is set to 5 minutes
        private void BtnStartBreak_Click(object sender, EventArgs e)
        {
            EventHandler handler = new EventHandler(TimerEventProcessorBreak);
            breakTimer.Tick += handler;
            breakTimer.Interval = 300000;
            breakTimer.Start();
            TbBreakTime.Text = "Active";
            DisableButtons();
        }
        //On load set text of TB
        private void PomadoroForm_Load(object sender, EventArgs e)
        {
            TbPomTime.Text = "Inactive";
            TbBreakTime.Text = "Inactive";
        }
    }
}
