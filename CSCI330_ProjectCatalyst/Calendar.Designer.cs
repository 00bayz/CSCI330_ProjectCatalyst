
namespace CSCI330_ProjectCatalyst
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntryText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalenderDisplay = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveAllButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SchedulerList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ToText = new System.Windows.Forms.TextBox();
            this.FromText = new System.Windows.Forms.TextBox();
            this.DetailsText = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SyncButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryText
            // 
            this.EntryText.Location = new System.Drawing.Point(34, 46);
            this.EntryText.Name = "EntryText";
            this.EntryText.Size = new System.Drawing.Size(261, 29);
            this.EntryText.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(301, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalenderDisplay);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(78, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar";
            // 
            // CalenderDisplay
            // 
            this.CalenderDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalenderDisplay.Location = new System.Drawing.Point(7, 29);
            this.CalenderDisplay.Name = "CalenderDisplay";
            this.CalenderDisplay.TabIndex = 0;
            this.CalenderDisplay.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalenderDisplay_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calendar and Scheduler:";
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(289, 74);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReloadButton);
            this.groupBox2.Controls.Add(this.SyncButton);
            this.groupBox2.Controls.Add(this.RemoveButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.SaveAllButton);
            this.groupBox2.Controls.Add(this.CloseButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scheduler Controls";
            // 
            // RemoveButton
            // 
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveButton.Location = new System.Drawing.Point(5, 74);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 30);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(6, 28);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 30);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add New";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveAllButton.Location = new System.Drawing.Point(289, 28);
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(90, 30);
            this.SaveAllButton.TabIndex = 5;
            this.SaveAllButton.Text = "Save All";
            this.SaveAllButton.UseVisualStyleBackColor = true;
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SchedulerList);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(403, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 293);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scheduler";
            // 
            // SchedulerList
            // 
            this.SchedulerList.FormattingEnabled = true;
            this.SchedulerList.ItemHeight = 21;
            this.SchedulerList.Location = new System.Drawing.Point(7, 29);
            this.SchedulerList.Name = "SchedulerList";
            this.SchedulerList.Size = new System.Drawing.Size(372, 256);
            this.SchedulerList.TabIndex = 0;
            this.SchedulerList.SelectedValueChanged += new System.EventHandler(this.SchedulerList_SelectedValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ToText);
            this.groupBox4.Controls.Add(this.FromText);
            this.groupBox4.Controls.Add(this.DetailsText);
            this.groupBox4.Controls.Add(this.FromLabel);
            this.groupBox4.Controls.Add(this.ToLabel);
            this.groupBox4.Controls.Add(this.DetailsLabel);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(404, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 126);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Event Details";
            // 
            // ToText
            // 
            this.ToText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToText.Location = new System.Drawing.Point(75, 91);
            this.ToText.Name = "ToText";
            this.ToText.Size = new System.Drawing.Size(302, 29);
            this.ToText.TabIndex = 5;
            // 
            // FromText
            // 
            this.FromText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FromText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FromText.Location = new System.Drawing.Point(75, 55);
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(302, 29);
            this.FromText.TabIndex = 4;
            // 
            // DetailsText
            // 
            this.DetailsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DetailsText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailsText.Location = new System.Drawing.Point(75, 21);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(302, 29);
            this.DetailsText.TabIndex = 3;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(9, 58);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(50, 21);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(13, 94);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(46, 21);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "Until:";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(9, 24);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(60, 21);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Details:";
            // 
            // SyncButton
            // 
            this.SyncButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SyncButton.Location = new System.Drawing.Point(102, 28);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(90, 30);
            this.SyncButton.TabIndex = 8;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncSelectedInfo);
            // 
            // ReloadButton
            // 
            this.ReloadButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReloadButton.Location = new System.Drawing.Point(102, 74);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(90, 30);
            this.ReloadButton.TabIndex = 9;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EntryText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntryText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar CalenderDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox SchedulerList;
        private System.Windows.Forms.Button SaveAllButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ToText;
        private System.Windows.Forms.TextBox FromText;
        private System.Windows.Forms.TextBox DetailsText;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.Button ReloadButton;
    }
}