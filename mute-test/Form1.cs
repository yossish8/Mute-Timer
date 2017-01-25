using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mute_test
{
    public partial class Form1 : Form
    {
        //most logic goes here

        //decalarions for mute. mute by calling SendMessageW. 
        //this code was copied from StackOverflow. i have no idea how it works.
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        //Constants
        const int MINUTES_TO_SECONDS = 60;
        const int HOURS_TO_SECONDS = 3600;
        const int SECONDS_TO_MINUTES = 60;
        const int SECONDS_TO_HOURS = 3600;
        const int REMINDER_SECONDS = 60;
        const int HOURS_IN_A_DAY = 24;
        const int MINUTES_IN_AN_HOUR = 60;

        //class vars
        public String exactHourToMute;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hours = (timerSeconds / SECONDS_TO_HOURS).ToString();
            string minutes = (timerSeconds / SECONDS_TO_MINUTES % 60).ToString();
            string secondsRemainder = (timerSeconds % REMINDER_SECONDS).ToString();
            //update time remaining lable:
            this.countdown.Text = hours + ':' + minutes + ':' + secondsRemainder;

            //as long as time > 0 keep tiking. when time = 0 mute and exit
            if (timerSeconds > 0)
            {
                timerSeconds--;
            }
            else if(timerSeconds==0)
            { 
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                Application.Exit();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            startCountdown();
        }

        private void inputHours_ValueChanged(object sender, EventArgs e)
        {
            startCountdown();
        }
        private void startCountdown()
        {
            //when value changes, update countdown automaticlly
            timerSeconds = (int)inputMinutes.Value * MINUTES_TO_SECONDS + (int)inputHours.Value * HOURS_TO_SECONDS;
            if (timerSeconds == 0)
            {
                timerSeconds = -1;
            }
            updateExactTimeToMute();
        }
        private void updateExactTimeToMute()
        {
            specifyHour.ResetText();
            specifyMinute.ResetText();
            int currentTimeHour = DateTime.Now.Hour;
            int currentTimeMinutes = DateTime.Now.Minute;
            int exactHour = ((timerSeconds / SECONDS_TO_HOURS) + currentTimeHour) % 24;
            int exactMinute = ((timerSeconds % SECONDS_TO_HOURS) / SECONDS_TO_MINUTES) + currentTimeMinutes;
            if(exactMinute > 59)
            {
                exactHour++;
                exactMinute -= 60;
            }
            exactHourToMute = exactHour.ToString() + ':' + exactMinute.ToString();
            muteAtOclockLable.Text = exactHourToMute;
        }

        private void specifyHour_ValueChanged(object sender, EventArgs e)
        {
            specifyUpdateTimers();
        }

        private void specifyMinute_ValueChanged(object sender, EventArgs e)
        {
            specifyUpdateTimers();
        }
        private void specifyUpdateTimers()
        {
            inputMinutes.ResetText();
            inputHours.ResetText();
            int hourInput = (int)specifyHour.Value;
            int minuteInput = (int)specifyMinute.Value;
            exactHourToMute = hourInput.ToString() + ':' + minuteInput.ToString();
            muteAtOclockLable.Text = exactHourToMute;
            int currentTimeHour = DateTime.Now.Hour;
            int currentTimeMinutes = DateTime.Now.Minute;
            int amountOfMinutes;
            int amountOfHours;
            if (hourInput == currentTimeHour)
            {
                if(minuteInput < currentTimeMinutes)
                {
                    amountOfHours = 23;
                    amountOfMinutes = MINUTES_IN_AN_HOUR - (currentTimeMinutes - minuteInput);
                }
                else if (minuteInput > currentTimeMinutes)
                {
                    amountOfHours = 0;
                    amountOfMinutes = minuteInput - currentTimeMinutes;
                }
                else
                {
                    amountOfHours = amountOfMinutes = -1;
                }
            }
            else
            {
                if (hourInput < currentTimeHour)
                {
                    amountOfHours = HOURS_IN_A_DAY - (currentTimeHour - hourInput);
                }
                else if (hourInput > currentTimeHour)
                {
                    amountOfHours = hourInput - currentTimeHour;
                }
                else
                {
                    amountOfHours = 0;
                }
                if (minuteInput < currentTimeMinutes)
                {
                    amountOfMinutes = MINUTES_IN_AN_HOUR - (currentTimeMinutes - minuteInput);
                    amountOfHours--;
                }
                else if (minuteInput > currentTimeMinutes)
                {
                    amountOfMinutes = minuteInput - currentTimeMinutes;
                }
                else
                {
                    amountOfMinutes = 0;
                }
            }
           
            timerSeconds = amountOfHours * HOURS_TO_SECONDS + amountOfMinutes * MINUTES_TO_SECONDS;
        }
    }
}
