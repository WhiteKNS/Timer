using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer; //system timer
        SoundPlayer soundPlayer; //sound player
        string wavPath = @"C:\\Users\\NATALYA\\Downloads\\"; //path for music
        DateTime snoozeTime; //time for snoozing
        const string STOPPED = "Stopped..."; //constant to label "Stop"
        const string RUNNING = "Running...";//constant to label "Running..."

        public Form1()
        {
            InitializeComponent(); // create form here

            this.buttonStart.Click += new System.EventHandler(this.btnStart_Click); //add delegates
            this.buttonStop.Click += new System.EventHandler(this.btnStop_Click);
            this.selectSound.Click += new System.EventHandler(this.buttonSelectSound_Click);
            this.comboBoxSelectSound.SelectedValueChanged += new System.EventHandler(this.getSound);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.AlarmDataChanged);
            //this.checkBoxSnoozeTime.CheckedChanged += new System.EventHandler(this.getSound);
            getSoundPaths(); //get all available music from computer
            soundPlayer = new System.Media.SoundPlayer(@"C:\\Users\\NATALYA\\Downloads\\Zydeco_Piano_Party.wav"); //default music
        }

        private void Form1_Load(object sender, EventArgs e) //form loads here
        {
            timer = new System.Timers.Timer(); // get current time
            timer.Interval = 1000; //set interval
            timer.Elapsed += TimeElapsed; //set elapsed time
        }

        private void AlarmDataChanged(object sender, EventArgs e)
        {
            snoozeTime = dateTimePicker.Value; // set snooze time here
        }

        private void AlarmPlaying(DateTime currentTime) { //play sound
            if (lblStatus.Text == STOPPED) return; // if alarm clock was stopped, we must do anything
            timer.Stop(); //stop timer

            UpdateLabel upd = UpdateDataLable; //we'll update label here

            if (lblStatus.InvokeRequired) //if alarm is running
                Invoke(upd, lblStatus, "Stop"); //set status as 'Stop'

            soundPlayer.PlayLooping(); // set loop

            if (checkBoxSnoozeTime.Checked) // if snooze time is checked
                snoozeTime = currentTime.AddMinutes(5); // set snooze time as 5 minutes
        }

        private void TimeElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now; //get current time

            DateTime userTime;

            if (checkBoxSnoozeTime.Checked) // 
                userTime = snoozeTime;         // if snooze time checked, set new time as snooze time
            else userTime = dateTimePicker.Value; // if not - set new time as user time

            if ((currentTime.Hour == userTime.Hour) && (currentTime.Minute == userTime.Minute) && (currentTime.Second == userTime.Second)) {
                AlarmPlaying(currentTime); // if it's time of alarm, play it
            }
        }

        delegate void UpdateLabel(Label label, string value);

        private void UpdateDataLable(Label label, string value)
        {
            label.Text = value;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start(); // start timer
            soundPlayer.Stop(); // if some other sound was playing, stop it
            lblStatus.Text = RUNNING; // set text as 'running'
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();//sop timer
            soundPlayer.Stop();// if some other sound was playing, stop it
            lblStatus.Text = STOPPED;// set current label text as 'running'
        }

        private void getSoundPaths() //get all paths here
        {
            string[] wavFiles = Directory.GetFiles(wavPath, "*.wav"); // get all files with .wav extension
            foreach (string file in wavFiles) {
                comboBoxSelectSound.Items.Add(Path.GetFileName(file));
            }
        }

        private void getSound(object sender, EventArgs e) {
           soundPlayer.Stop();
           string soundLocation = wavPath + this.comboBoxSelectSound.SelectedItem.ToString();
            if (File.Exists(soundLocation)) {
                try
                {
                    soundPlayer.SoundLocation = soundLocation;
                    soundPlayer.Play();
                }
                catch (Exception ex) {
                    System.Console.Write(ex.Message);
                }
            }
        }

        private void buttonSelectSound_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog selectSound = new OpenFileDialog(); // get soundws from open filedialog
            selectSound.Filter = "Wav files|*.wav";
            selectSound.Title = "Select Wav Files";

            if (selectSound.ShowDialog() == System.Windows.Forms.DialogResult.OK) // if user pressed 'ok'
            {
                string directoryPath = selectSound.FileName; // get directory path
                if (File.Exists(directoryPath)) { // if file exists
                    soundPlayer.SoundLocation = directoryPath; //set new sound
                    soundPlayer.Play(); // play new sound
                }
            }
        }
    }
}
