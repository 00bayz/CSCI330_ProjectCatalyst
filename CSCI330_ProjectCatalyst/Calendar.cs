using CSCI330_ProjectCatalyst.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI330_ProjectCatalyst
{
    public partial class Calendar : Form
    {
        public class CalendarInfo
        {
            public string details { get; set; }
            public string from { get; set; }
            public string to { get; set; }
        }

        static string moduleLocation = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "calendar";
        static string dataLocation = moduleLocation + Path.DirectorySeparatorChar + "data.json";
        Dictionary<string, List<CalendarInfo>> cachedJsonInfo;
        List<CalendarInfo> calenderData = new List<CalendarInfo>();
        CalendarInfo selectedInfo;

        public Calendar()
        {
            InitializeComponent();
        }

        private void CalenderDisplay_DateChanged(object sender, DateRangeEventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString("MM/dd/yyyy");
            LoadScheduleData(dataLocation, EntryText.Text);
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString("MM/dd/yyyy");
            LoadScheduleData(dataLocation, EntryText.Text);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CalenderDisplay.SelectionStart = DateTime.Parse(EntryText.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadScheduleData(string location, string date)
        {
            calenderData.Clear();

            string fileData = @"{}";

            if (File.Exists(location))
            {
                fileData = File.ReadAllText(location);
            }

            cachedJsonInfo = JsonConvert.DeserializeObject<Dictionary<string, List<CalendarInfo>>>(fileData);
            if (cachedJsonInfo.ContainsKey(date))
            {
                cachedJsonInfo.TryGetValue(date, out calenderData);
                Console.WriteLine("Found Data for {0}: {1} values", date, calenderData.Count);
            }
            RefreshListView();
        }

        public void SaveSchedulerData(string location, string date, List<CalendarInfo> info)
        {
            Console.WriteLine("Writing for date {0}: {1} total values", date, info.Count);
            cachedJsonInfo[date] = info;
            if (!Directory.Exists(moduleLocation))
            {
                Directory.CreateDirectory(moduleLocation);
            }
            using (StreamWriter file = File.CreateText(location))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, cachedJsonInfo);
            }
            Console.WriteLine("Saved Successfully to {0}", location);
        }

        public void RefreshListView()
        {
            SchedulerList.Items.Clear();
            foreach (CalendarInfo info in calenderData)
            {
                SchedulerList.Items.Add(info.details);
            }
            ToggleButtons(false);
        }

        public void ToggleButtons(bool hasSelectedItem)
        {
            //AddButton.Enabled = hasSelectedItem;
            RemoveButton.Enabled = hasSelectedItem;
            DetailsText.Enabled = hasSelectedItem;
            ToText.Enabled = hasSelectedItem;
            FromText.Enabled = hasSelectedItem;
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            SaveSchedulerData(dataLocation, EntryText.Text, calenderData);
        }

        private void SchedulerList_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedInfo = FindInfoFromField(SchedulerList.SelectedItem.ToString());
            bool hasData = selectedInfo != null;
            if (hasData)
            {
                DetailsText.Text = selectedInfo.details;
                FromText.Text = selectedInfo.from;
                ToText.Text = selectedInfo.to;
            }
            ToggleButtons(hasData);
        }

        public CalendarInfo FindInfoFromField(string details)
        {
            foreach (CalendarInfo value in calenderData)
            {
                if (value.details == details)
                {
                    return value;
                }
            }
            return null;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            CalendarInfo infoToRemove = FindInfoFromField(SchedulerList.SelectedItem.ToString());
            if (infoToRemove != null)
            {
                calenderData.Remove(infoToRemove);
            }
            RefreshListView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            RandomGenerator generator = new RandomGenerator();
            calenderData.Add(new CalendarInfo()
            {
                details = string.Format("New Event {0}", generator.RandomString(5)),
                from = "12:00 AM",
                to = "12:00 PM"
            });
            RefreshListView();
        }

        private void SyncSelectedInfo(object sender, EventArgs e)
        {
            if (selectedInfo != null)
            {
                calenderData.Remove(selectedInfo);
                selectedInfo.details = DetailsText.Text;
                selectedInfo.from = FromText.Text;
                selectedInfo.to = ToText.Text;
                calenderData.Add(selectedInfo);

                RefreshListView();
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadScheduleData(dataLocation, EntryText.Text);
        }
    }
}
