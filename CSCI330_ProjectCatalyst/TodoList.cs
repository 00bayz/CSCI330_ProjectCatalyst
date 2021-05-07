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
    public partial class TodoList : Form
    {
        public TodoList()
        {
            InitializeComponent();
        }

        public class TodoInfo
        {
            public int id { get; set; }
            public string title { get; set; }
            public string scheduled_at { get; set; }
        }

        static string moduleLocation = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "todo";
        static string dataLocation = moduleLocation + Path.DirectorySeparatorChar + "data.json";
        Dictionary<string, List<TodoInfo>> cachedJsonInfo;
        List<TodoInfo> calenderData = new List<TodoInfo>();
        TodoInfo selectedInfo;

        private void CalenderDisplay_DateChanged(object sender, DateRangeEventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString("MM/dd/yyyy");
            LoadTodoData(dataLocation, EntryText.Text);
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            EntryText.Text = CalenderDisplay.SelectionStart.ToString("MM/dd/yyyy");
            LoadTodoData(dataLocation, EntryText.Text);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CalenderDisplay.SelectionStart = DateTime.Parse(EntryText.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadTodoData(string location, string date)
        {
            calenderData.Clear();

            string fileData = @"{}";

            if (File.Exists(location))
            {
                fileData = File.ReadAllText(location);
            }

            cachedJsonInfo = JsonConvert.DeserializeObject<Dictionary<string, List<TodoInfo>>>(fileData);
            if (cachedJsonInfo.ContainsKey(date))
            {
                cachedJsonInfo.TryGetValue(date, out calenderData);
                Console.WriteLine("Found Data for {0}: {1} values", date, calenderData.Count);
            }
            RefreshListView();
        }

        public void SaveTodoData(string location, string date, List<TodoInfo> info)
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
            TodoListBox.Items.Clear();
            foreach (TodoInfo info in calenderData)
            {
                TodoListBox.Items.Add(info.title);
            }
            ToggleButtons(false);
        }

        public void ToggleButtons(bool hasSelectedItem)
        {
            //AddButton.Enabled = hasSelectedItem;
            RemoveButton.Enabled = hasSelectedItem;
            TodoTitleText.Enabled = hasSelectedItem;
            FromText.Enabled = hasSelectedItem;
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            SaveTodoData(dataLocation, EntryText.Text, calenderData);
        }

        private void TodoList_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedInfo = FindInfoFromField(TodoListBox.SelectedItem.ToString());
            bool hasData = selectedInfo != null;
            if (hasData)
            {
                TodoTitleText.Text = selectedInfo.title;
                FromText.Text = selectedInfo.scheduled_at;
            }
            ToggleButtons(hasData);
        }

        public TodoInfo FindInfoFromField(string title)
        {
            foreach (TodoInfo value in calenderData)
            {
                if (value.title == title)
                {
                    return value;
                }
            }
            return null;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            TodoInfo infoToRemove = FindInfoFromField(TodoListBox.SelectedItem.ToString());
            if (infoToRemove != null)
            {
                calenderData.Remove(infoToRemove);
                SaveTodoData(dataLocation, EntryText.Text, calenderData);
            }
            RefreshListView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            RandomGenerator generator = new RandomGenerator();
            string title = newTodoTitle.Text.Trim();
            if(title.Length > 0)
            {
                int len = calenderData.Count();
                int id = 1;
                if(len > 0)
                {
                    TodoInfo last = calenderData[len - 1];
                    int last_id = last.id;
                    id = last_id + 1;
                }

                calenderData.Add(new TodoInfo()
                {
                    id = id,
                    title = title,
                    scheduled_at = "12:00 PM"
                });

                newTodoTitle.Clear();
                SaveTodoData(dataLocation, EntryText.Text, calenderData);
            }
            RefreshListView();
        }

        private void SyncSelectedInfo(object sender, EventArgs e)
        {
            if (selectedInfo != null)
            {
                // calenderData.Remove(selectedInfo);
                TodoInfo item = new TodoInfo();
                item.id = selectedInfo.id;
                item.title = TodoTitleText.Text ?? selectedInfo.title;
                item.scheduled_at = FromText.Text ?? selectedInfo.scheduled_at;
                // calenderData.Add(selectedInfo);

                calenderData[calenderData.FindIndex(ind => ind.id.Equals(selectedInfo.id))] = item;
                SaveTodoData(dataLocation, EntryText.Text, calenderData);

                RefreshListView();
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadTodoData(dataLocation, EntryText.Text);
        }
    }
}
