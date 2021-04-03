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
    public partial class CatalystMain : Form
    {
        public CatalystMain()
        {
            InitializeComponent();
        }

        private void TodoButton_Click(object sender, EventArgs e)
        {
            using (TodoList TodoListApp = new TodoList())
            {
                TodoListApp.ShowDialog();
            }
        }

        private void PomodoroButton_Click(object sender, EventArgs e)
        {
            using (Pomodoro PomodoroApp = new Pomodoro())
            {
                PomodoroApp.ShowDialog();
            }
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            using (Calendar CalendarApp = new Calendar())
            {
                CalendarApp.ShowDialog();
            }
        }

        private void TrackerButton_Click(object sender, EventArgs e)
        {
            using (HabitTracker HabitTrackerApp = new HabitTracker())
            {
                HabitTrackerApp.ShowDialog();
            }
        }

        private void RemindersButton_Click(object sender, EventArgs e)
        {
            using (Reminders RemindersApp = new Reminders())
            {
                RemindersApp.ShowDialog();
            }
        }
    }
}
