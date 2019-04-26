using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class Form1 : Form
    {
        DateTime final;
        TimeSpan timeLeft;
        string BaseCountDownText = "Weken       Dagen       Uren        Minuten      Seconden";
        public Form1()
        {
            InitializeComponent();
            lblCountDown.Text = BaseCountDownText;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CountDownTimer.Start();
            final = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day
                , dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
        }

        private void btnCountSpecific_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt16(nudDays.Value);
            int hours = Convert.ToInt16(nudHours.Value);
            int mins = Convert.ToInt16(nudMins.Value);
            int secs = Convert.ToInt16(nudSecs.Value);

            CountDownTimer.Start();
            timeLeft = new TimeSpan(days, hours, mins, secs);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            CountDownTimer.Stop();
        }
        private void btnResume_Click(object sender, EventArgs e)
        {
            CountDownTimer.Start();
        }

        private void countDown(object sender, EventArgs e)
        {
            if (final != DateTime.MinValue)
                timeLeft = final - DateTime.Now;

            else
                timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));

            int days = timeLeft.Days % 7;
            int weeks = (timeLeft.Days - days) / 7;

            string countDownText = BaseCountDownText + "\n" + weeks + "                 " + days + "                  " + timeLeft.Hours +
                    "               " + timeLeft.Minutes + "                    " + timeLeft.Seconds;
                lblCountDown.Text = countDownText;

            if (timeLeft == new TimeSpan(0, 0, 0, 0))
            {
                CountDownTimer.Stop();
                MessageBox.Show("Time's up");
            }
        }

        private void gbCountTo_Enter(object sender, EventArgs e)
        {

        }
    }
}
