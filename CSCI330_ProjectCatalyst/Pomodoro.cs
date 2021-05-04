using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI330_ProjectCatalyst
{
    public partial class Pomodoro : Form
    {
        private struct Settings
        {
            private static int _pomodoroDur;
            private static int _shortBreakDur;
            private static int _longBreakDur;
            private static int _longBreakInterval;

            public Settings(int a, int b, int c, int d)
            {
                _pomodoroDur = a;
                _shortBreakDur = b;
                _longBreakDur = c;
                _longBreakInterval = d;
            }
            public int PomodoroDur
            {
                get
                {
                    return _pomodoroDur;
                }
                set
                {
                    _pomodoroDur = value;
                }
            }

            public int ShortBreakDur
            {
                get
                {
                    return _shortBreakDur;
                }
                set
                {
                    _shortBreakDur = value;
                }
            }

            public int LongBreakDur
            {
                get
                {
                    return _longBreakDur;
                }
                set
                {
                    _longBreakDur = value;
                }
            }

            public int LongBreakInterval
            {
                get
                {
                    return _longBreakInterval;
                }
                set
                {
                    _longBreakInterval = value;
                }
            }
        }

        private string[] Status = new string[] { "Pomodoro", "Short Break", "Long Break" };
        private const int DEF_POMODORO_DUR = 25;
        private const int DEF_SHORT_BREAK_DUR = 5;
        private const int DEF_LONG_BREAK_DUR = 15;
        private const int DEF_INTERVAL = 4;
        private static int PomodoroCount = 0;
        private static int StatusCount = 0;
        private static bool IsRunning = false;
        private static bool IsPaused = false;
        private static DateTime StartTime;
        private static DateTime StopTime;
        private static int PausedSecs = 0;
        private static int PausedMins = 0;
        private static int ElapsedMins;
        private static int ElapsedSecs;
        private static int DisplayMins;
        private static int DisplaySecs;
        private static Settings CurrentSettings = new Settings(DEF_POMODORO_DUR, DEF_SHORT_BREAK_DUR, DEF_LONG_BREAK_DUR, DEF_INTERVAL);

        public Pomodoro()
        {
            InitializeComponent();
            InitPopulateSettingsForm();
        }

        private void InitPopulateSettingsForm()
        {
            SetPomNUD.Value = CurrentSettings.PomodoroDur;
            SetShortNUD.Value = CurrentSettings.ShortBreakDur;
            SetLongNUD.Value = CurrentSettings.LongBreakDur;
            SetIntervalNUD.Value = CurrentSettings.LongBreakInterval;
        }

        private void ToggleSettings(bool isRunning)
        {
            SetPomNUD.Enabled = (isRunning) ? false : true;
            SetShortNUD.Enabled = (isRunning) ? false : true;
            SetLongNUD.Enabled = (isRunning) ? false : true;
            SetIntervalNUD.Enabled = (isRunning) ? false : true;
        }

        private void TogglePauseResumeButtonText(bool isPaused)
        {
            BtnPauseResume.Text = (IsPaused) ? "Resume" : "Pause";
        }

        private void TogglePauseResumeButtonVisibility(bool isRunning)
        {
            BtnPauseResume.Visible = (isRunning) ? true : false;
        }

        private void ToggleStartStopButtonText(bool isRunning)
        {
            BtnStartStop.Text = (isRunning) ? "Stop" : "Start";
        }

        private void SetPomNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.PomodoroDur = Convert.ToInt32(SetPomNUD.Value);
            UpdateTimerDisplay(CurrentSettings.PomodoroDur, 0);
        }

        private void SetPomNUD_TextChanged(object sender, EventArgs e)
        {
            CurrentSettings.PomodoroDur = Convert.ToInt32(SetPomNUD.Value);
            UpdateTimerDisplay(CurrentSettings.PomodoroDur, 0);
        }

        private void SetShortNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.ShortBreakDur = Convert.ToInt32(SetShortNUD.Value);
        }

        private void SetLongNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.LongBreakDur = Convert.ToInt32(SetLongNUD.Value);
        }

        private void SetIntervalNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.LongBreakInterval = Convert.ToInt32(SetIntervalNUD.Value);
        }

        private void StartCountdown()
        {
            Timer.Start();
            IsRunning = true;
            StartTime = DateTime.Now;
        }

        private void PauseCountdown()
        {
            Timer.Stop();
            StopTime = DateTime.Now;
        }

        private void ResumeCountdown()
        {
            Timer.Start();
            DateTime resumeTime = DateTime.Now;
            PausedMins += (resumeTime - StopTime).Minutes;
            PausedSecs += (resumeTime - StopTime).Seconds;
        }

        private void StopAndResetTimer()
        {
            Timer.Stop();
            ElapsedMins = 0;
            ElapsedSecs = 0;
            IsRunning = false;
            IsPaused = false;
            PausedMins = 0;
            PausedSecs = 0;
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (IsRunning) // Clicking "Stop" Button
            {
                StopAndResetTimer();
                ToggleStartStopButtonText(IsRunning);
                ToggleSettings(IsRunning);
                TogglePauseResumeButtonVisibility(IsRunning);
                TogglePauseResumeButtonText(IsPaused);
            }
            else
            {
                IsRunning = true;
                ToggleStartStopButtonText(IsRunning);
                ToggleSettings(IsRunning);
                TogglePauseResumeButtonVisibility(IsRunning);
                TogglePauseResumeButtonText(IsPaused);
                UpdateStatusDisplay();
                StartCountdown();
            }
        }

        private void BtnPauseResume_Click(object sender, EventArgs e)
        {
            if (IsPaused)
            {
                IsPaused = false;
                ResumeCountdown();
            }
            else
            {
                IsPaused = true;
                PauseCountdown();
            }
            TogglePauseResumeButtonText(IsPaused);
        }

        private void UpdateTimerDisplay(int mins, int secs)
        {
            if (mins < 10 && secs < 10)
            {
                PomTimerDisplayLabel.Text = $"0{mins}:0{secs}";
            }
            else if (mins < 10)
            {
                PomTimerDisplayLabel.Text = $"0{mins}:{secs}";
            }
            else if (secs < 10)
            {
                PomTimerDisplayLabel.Text = $"{mins}:0{secs}";
            }
            else
            {
                PomTimerDisplayLabel.Text = $"{mins}:{secs}";
            }
        }

        private void UpdateStatusDisplay()
        {
            StatusLabel.Visible = true;
            StatusLabel.Text = Status[StatusCount];
        }

        private void UpdateStatus()
        {
            if (StatusCount == 1 && PomodoroCount == CurrentSettings.LongBreakInterval)
            {
                StatusCount = 2;
            }
            else if (StatusCount >= 2)
            {
                StatusCount = 0;
            }
            else
            {
                StatusCount++;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ElapsedSecs = (DateTime.Now - StartTime).Seconds;
            ElapsedMins = (DateTime.Now - StartTime).Minutes;
            if (StatusCount == 0)
            {
                if (ElapsedMins - CurrentSettings.PomodoroDur == 0)
                {
                    UpdateTimerDisplay(0, 0);
                    Timer.Stop();
                    PomodoroCount++;
                    StopAndResetTimer();
                    UpdateStatus();
                    MessageBox.Show($"You have completed {PomodoroCount} Pomodoros!", "Great Job!");
                }
                else
                {
                    DisplaySecs = (60 - ElapsedSecs) + PausedSecs;
                    DisplayMins = (CurrentSettings.PomodoroDur - ElapsedMins - 1) + PausedMins;
                    UpdateTimerDisplay(DisplayMins, DisplaySecs);
                }
            }
            else if (StatusCount == 1)
            {
                if (ElapsedMins - CurrentSettings.ShortBreakDur == 0)
                {
                    UpdateTimerDisplay(0, 0);
                    Timer.Stop();
                    StopAndResetTimer();
                    UpdateStatus();
                    MessageBox.Show("Short Break over!");
                }
                else
                {
                    DisplaySecs = (60 - ElapsedSecs) + PausedSecs;
                    DisplayMins = (CurrentSettings.PomodoroDur - ElapsedMins - 1) + PausedMins;
                    UpdateTimerDisplay(DisplayMins, DisplaySecs);
                }
            }
            else if (StatusCount == 2)
            {
                if (ElapsedMins - CurrentSettings.LongBreakDur == 0)
                {
                    UpdateTimerDisplay(0, 0);
                    Timer.Stop();
                    StopAndResetTimer();
                    UpdateStatus();
                    MessageBox.Show("Long Break over!");
                }
                else
                {
                    DisplaySecs = (60 - ElapsedSecs) + PausedSecs;
                    DisplayMins = (CurrentSettings.PomodoroDur - ElapsedMins - 1) + PausedMins;
                    UpdateTimerDisplay(DisplayMins, DisplaySecs);
                }
            }
            
        }
    }
}
