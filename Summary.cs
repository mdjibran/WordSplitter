using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordSplitter.CustomClasses;

namespace WordSplitter
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }
        DateTime StartTIme;

        delegate void SetTextCallback(string text);

        private string HashChars()
        {
            string result = new String('#', 23);

            return '\t' + result + '\t';
        }
        private void SetText(string text)
        {
            if (this._rtbSummaryBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this._rtbSummaryBox.Text += text;
            }
        }

        public void AddSummaryRow(string row)
        {
            string curText = row.Trim() + Environment.NewLine;

            //_rtbSummaryBox.Text += row.Trim() + Environment.NewLine;
            SetText(curText);
        }

        public void SetupStage()
        {
            StartTIme = DateTime.Now;
            string line = HashChars() + " PROCESS STARTED " + HashChars() + Environment.NewLine;
            line += "Start Time: " + DateTime.Now.ToShortDateString() + " | " + StartTIme.ToShortTimeString() + Environment.NewLine;

            _rtbSummaryBox.Text += line;
            //SetText(line);
        }

        public void AddNewLIne()
        {
            SetText(Environment.NewLine);
        }
        public void CleanStage()
        {
            string line = Environment.NewLine + Environment.NewLine + 
                            "Process Completed. " + Environment.NewLine + Environment.NewLine;

            TimeSpan span = DateTime.Now - StartTIme;
            double duration = span.TotalMinutes;
            int DurationInt = Convert.ToInt32(Math.Floor(duration));


            if (DurationInt < 1)
            {
                duration = span.TotalSeconds;
                DurationInt = Convert.ToInt32(Math.Ceiling(duration));
                line += "Duration: " + DurationInt.ToString() + " Second(s)." + Environment.NewLine;
            }
            else
            {
                line += "Duration: " + DurationInt.ToString() + " Minute(s)." + Environment.NewLine;
            }

            line += HashChars() + " PROCESS FINISHED " + HashChars();

            line += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            //_rtbSummaryBox.Text += line;
            SetText(line);
        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVariables.SaveLogs(_rtbSummaryBox.Text);
        }

        public void SetPreviousLog(string log)
        {
            _rtbSummaryBox.Text = log;
        }

        private void _rtbSummaryBox_TextChanged(object sender, EventArgs e)
        {
            _rtbSummaryBox.SelectionStart = _rtbSummaryBox.TextLength;
            _rtbSummaryBox.ScrollToCaret();
        }
    }
}
