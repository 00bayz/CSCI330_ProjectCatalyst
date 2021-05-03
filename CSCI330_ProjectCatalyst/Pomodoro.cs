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
            private static int _pomodoroDur = 25;
            private static int _shortBreakDur = 5;
            private static int _longBreakDur = 15;
            private static int _longBreakInterval = 4;
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

        private enum Status
        {
            Pomodoro = 0,
            ShortBreak = 1,
            LongBreak = 2
        }

        private static DateTime StartTime;
        private static DateTime Stoptime;
        private static int ElapsedMins = 0;
        private static int ElapsedSecs = 0;
        private static Settings CurrentSettings = new Settings();

        public Pomodoro()
        {
            InitializeComponent();
            SetDefaultSettings();
        }

        private void SetDefaultSettings()
        {
            SetPomNUD.Value = CurrentSettings.PomodoroDur;
            SetShortNUD.Value = CurrentSettings.ShortBreakDur;
            SetLongNUD.Value = CurrentSettings.LongBreakDur;
            SetIntervalNUD.Value = CurrentSettings.LongBreakInterval;
        }

        private int MinutesReminaing()
        {
            return CurrentSettings.PomodoroDur - ElapsedMins;
        }

        private int SecondsRemaining()
        {
            return ((CurrentSettings.PomodoroDur * 60) - ElapsedSecs) % 60;
        }

        private void SetPomNUD_ValueChanged(object sender, EventArgs e)
        {
            CurrentSettings.PomodoroDur = Convert.ToInt32(SetPomNUD.Value);
            PomTimerDisplayLabel.Text = $"{CurrentSettings.PomodoroDur.ToString()}:00";
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
    }
}
