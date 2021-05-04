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
        private int[] Durations = new int[] { DEF_POMODORO_DUR * 60, DEF_SHORT_BREAK_DUR * 60, DEF_LONG_BREAK_DUR * 60 };  // in seconds
        private const int DEF_POMODORO_DUR = 25;    // in minutes
        private const int DEF_SHORT_BREAK_DUR = 5;  // in minutes
        private const int DEF_LONG_BREAK_DUR = 15;  // in minutes
        private const int DEF_INTERVAL = 4;
        private static int PomodoroCount = 0;
        private static int StatusCount = 0;
        private static bool IsRunning = false;
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

        private void Start()
        {
            IsRunning = true;
            Timer.Start();
        }

        private void Pause()
        {
            IsRunning = false;
            Timer.Stop();
        }

        private void Reset()    // RESETS ENTIRE POMODORO
        {
            IsRunning = false;
            Timer.Stop();
            CurrentSettings = new Settings(DEF_POMODORO_DUR, DEF_SHORT_BREAK_DUR, DEF_LONG_BREAK_DUR, DEF_INTERVAL);
            PomodoroCount = 0;
            StatusCount = 0;
            Durations = new int[] { DEF_POMODORO_DUR * 60, DEF_SHORT_BREAK_DUR * 60, DEF_LONG_BREAK_DUR * 60 };
            InitPopulateSettingsForm();
            UpdateTimerDisplay(Durations[0]);
            ToggleBtnResetVisibility(IsRunning);
            ToggleSettingsFields(IsRunning);
            ToggleBtnStartPauseText(IsRunning);
        }

        private void Stop()     // WHEN TIMER RUNS OUT
        {
            IsRunning = false;
            Timer.Stop();
        }

        private void ToggleBtnResetVisibility(bool isRunning)
        {
            BtnReset.Visible = (isRunning) ? true : false;
        }

        private void ToggleBtnStartPauseText(bool isRunning)
        {
            BtnStartPause.Text = (isRunning) ? "Pause" : "Start";
        }

        private void ToggleSettingsFields(bool isRunning)
        {
            SetPomNUD.Enabled = (isRunning) ? false : true;
            SetShortNUD.Enabled = (isRunning) ? false : true;
            SetLongNUD.Enabled = (isRunning) ? false : true;
            SetIntervalNUD.Enabled = (isRunning) ? false : true;
        }

        private void SetPomNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.PomodoroDur = Convert.ToInt32(SetPomNUD.Value);
            UpdateTimerDisplay(CurrentSettings.PomodoroDur * 60);
            Durations[0] = CurrentSettings.PomodoroDur * 60;            
        }

        private void SetPomNUD_TextChanged(object sender, EventArgs e)
        {
            CurrentSettings.PomodoroDur = Convert.ToInt32(SetPomNUD.Value);
            UpdateTimerDisplay(CurrentSettings.PomodoroDur * 60);
            Durations[0] = CurrentSettings.PomodoroDur * 60;
        }

        private void SetShortNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.ShortBreakDur = Convert.ToInt32(SetShortNUD.Value);
            Durations[1] = CurrentSettings.ShortBreakDur * 60;
        }

        private void SetLongNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.LongBreakDur = Convert.ToInt32(SetLongNUD.Value);
            Durations[2] = CurrentSettings.LongBreakDur * 60;
        }

        private void SetIntervalNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.LongBreakInterval = Convert.ToInt32(SetIntervalNUD.Value);
        }

        private void UpdateTimerDisplay(int secs)
        {
            int displayMins = secs / 60;
            int displaySecs = secs % 60;
            if (displayMins < 10 && displaySecs < 10)
            {
                PomTimerDisplayLabel.Text = $"0{displayMins}:0{displaySecs}";
            }
            else if (displayMins < 10)
            {
                PomTimerDisplayLabel.Text = $"0{displayMins}:{displaySecs}";
            }
            else if (displaySecs < 10)
            {
                PomTimerDisplayLabel.Text = $"{displayMins}:0{displaySecs}";
            }
            else
            {
                PomTimerDisplayLabel.Text = $"{displayMins}:{displaySecs}";
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
            UpdateStatusDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (StatusCount == 0)           // POMODORO
            {
                Durations[0]--;
                UpdateTimerDisplay(Durations[0]);
                if (Durations[0] <= 0)
                {
                    Stop();
                    ToggleBtnStartPauseText(IsRunning);
                    ToggleBtnResetVisibility(IsRunning);
                    UpdateStatus();
                    Durations[0] = CurrentSettings.PomodoroDur * 60;
                }
            }
            else if (StatusCount == 1)      // SHORT BREAK
            {
                Durations[1]--;
                UpdateTimerDisplay(Durations[1]);
                if (Durations[1] <= 0)
                {
                    Stop();
                    ToggleBtnStartPauseText(IsRunning);
                    ToggleBtnResetVisibility(IsRunning);
                    UpdateStatus();
                    Durations[1] = CurrentSettings.PomodoroDur * 60;
                }
            } else if (StatusCount == 2)    // LONG BREAK
            {
                Durations[2]--;
                UpdateTimerDisplay(Durations[2]);
                if (Durations[2] <= 0)
                {
                    Stop();
                    ToggleBtnStartPauseText(IsRunning);
                    ToggleBtnResetVisibility(IsRunning);
                    UpdateStatus();
                    Durations[2] = CurrentSettings.PomodoroDur * 60;
                }
            }
        }

        private void BtnStartPause_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                Pause();
                ToggleBtnStartPauseText(IsRunning);
                return;
            }
            UpdateStatusDisplay();
            if (ShouldStartPomodoro())
            {
                Start();
                ToggleSettingsFields(IsRunning);
                ToggleBtnResetVisibility(IsRunning);
                ToggleBtnStartPauseText(IsRunning);
            }
            else if (ShouldStartShortBreak())
            {
                Start();
                ToggleSettingsFields(IsRunning);
                ToggleBtnResetVisibility(IsRunning);
                ToggleBtnStartPauseText(IsRunning);
            }
            else if (ShouldStartLongBreak())
            {
                Start();
                ToggleSettingsFields(IsRunning);
                ToggleBtnResetVisibility(IsRunning);
                ToggleBtnStartPauseText(IsRunning);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void StatusLabel_TextChanged(object sender, EventArgs e)
        {
            UpdateTimerDisplay(Durations[StatusCount]);
        }

        private bool ShouldStartPomodoro()
        {
            return (IsRunning == false && StatusCount == 0);
        }

        private bool ShouldStartShortBreak()
        {
            return (IsRunning == false && StatusCount == 1);
        }

        private bool ShouldStartLongBreak()
        {
            return (IsRunning == false && StatusCount == 2);
        }
    }
}
