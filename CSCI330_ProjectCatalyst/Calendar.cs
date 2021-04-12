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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void CalenderDisplay_DateChanged(object sender, DateRangeEventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CalenderDisplay.SelectionStart = DateTime.Parse(EntryText.Text);
        }
    }
}
