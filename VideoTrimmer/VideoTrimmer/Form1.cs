using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTrimmer
{
    public partial class MainForm : Form
    {
        private const string  fileFilter = "MP4 Files (*.mp4)|*.mp4|All Files (*.*)|*.*";
        public double ProgressComplete { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBrowseSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = fileFilter;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    textBoxSourceFile.Text = openFileDialog.FileName;
                    textBoxOutputFile.Text = openFileDialog.FileName.Insert(openFileDialog.FileName.Length-4, "-output");
                }
            }

            
        }

        private void buttonBrowseDestination_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = fileFilter;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    textBoxOutputFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            buttonStart.Enabled = false;
            StartTrimProcess();

            timer.Stop();
            timer.Dispose();
            buttonStart.Enabled = true;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int progress = int.Parse(ProgressComplete.ToString("0"));

                if (progress > 0)
                    UpdateProgressBar(progress);
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        private void UpdateProgressBar(int currentProgress)
        {
            if(InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate { UpdateProgressBar(currentProgress); });
                return;
            }

            progressBarMain.Value = currentProgress;
        }

        private bool InputsValidation()
        {

            return true;
        }

        private void StartTrimProcess()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"c:\ffmpeg\bin\ffmpeg.exe";
            process.StartInfo.Arguments = $"-ss {textBoxStartHour.Text}:{textBoxStartMinute.Text}:{textBoxStartSecond.Text} -i \"{textBoxSourceFile.Text}\" -to {textBoxEndHour.Text}:{textBoxEndMinute.Text}:{textBoxEndSecond.Text} -c copy \"{textBoxOutputFile.Text}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardError = true;

            textBox1.Text = process.StartInfo.Arguments;

            try
            {
                process.Start();
                StreamReader sr = process.StandardError;
                while (!sr.EndOfStream)
                {
                    string output = sr.ReadLine();
                    textBox1.Text += "\n" + output + "\n"; 
                    GetTrimProgress(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetTrimProgress(string v)
        {
            try
            {
                string[] split = v.Split(' ');
                foreach(var item in split)
                {
                    if(item.StartsWith("time="))
                    {
                        var time = item.Split('-');
                        ProgressComplete = TimeSpan.Parse(time[1]).TotalSeconds;

                    }
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
        }
    }
}
