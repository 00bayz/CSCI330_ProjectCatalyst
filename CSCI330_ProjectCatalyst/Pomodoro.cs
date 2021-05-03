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
            public static int PomodoroDur
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

            public static int ShortBreakDur
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

            public static int LongBreakDur
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

            public static int LongBreakInterval
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

        private static DateTime StartTime;
        private static DateTime Stoptime;
        private static int ElapsedMins = 0;
        private static int ElapsedSecs = 0;

        public Pomodoro()
        {
            InitializeComponent();
            SetDefaultSettings();
        }

        private void SetDefaultSettings()
        {
            SetPomNUD.Value = Settings.PomodoroDur;
            SetShortNUD.Value = Settings.ShortBreakDur;
            SetLongNUD.Value = Settings.LongBreakDur;
            SetIntervalNUD.Value = Settings.LongBreakInterval;
        }

        private int MinutesReminaing()
        {
            return Settings.PomodoroDur - ElapsedMins;
        }

        private int SecondsRemaining()
        {
            return ((Settings.PomodoroDur * 60) - ElapsedSecs) % 60;
        }
    }
}
