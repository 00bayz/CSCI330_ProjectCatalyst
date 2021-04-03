
namespace CSCI330_ProjectCatalyst
{
    partial class CatalystMain
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
            this.TodoButton = new System.Windows.Forms.Button();
            this.PomodoroButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.TrackerButton = new System.Windows.Forms.Button();
            this.RemindersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TodoButton
            // 
            this.TodoButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TodoButton.Location = new System.Drawing.Point(32, 16);
            this.TodoButton.Name = "TodoButton";
            this.TodoButton.Size = new System.Drawing.Size(160, 60);
            this.TodoButton.TabIndex = 0;
            this.TodoButton.Text = "To-Do List";
            this.TodoButton.UseVisualStyleBackColor = true;
            this.TodoButton.Click += new System.EventHandler(this.TodoButton_Click);
            // 
            // PomodoroButton
            // 
            this.PomodoroButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomodoroButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PomodoroButton.Location = new System.Drawing.Point(32, 92);
            this.PomodoroButton.Name = "PomodoroButton";
            this.PomodoroButton.Size = new System.Drawing.Size(160, 60);
            this.PomodoroButton.TabIndex = 1;
            this.PomodoroButton.Text = "Pomodoro Timer";
            this.PomodoroButton.UseVisualStyleBackColor = true;
            this.PomodoroButton.Click += new System.EventHandler(this.PomodoroButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarButton.Location = new System.Drawing.Point(32, 168);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(160, 60);
            this.CalendarButton.TabIndex = 2;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // TrackerButton
            // 
            this.TrackerButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TrackerButton.Location = new System.Drawing.Point(32, 244);
            this.TrackerButton.Name = "TrackerButton";
            this.TrackerButton.Size = new System.Drawing.Size(160, 60);
            this.TrackerButton.TabIndex = 3;
            this.TrackerButton.Text = "Habit Tracker";
            this.TrackerButton.UseVisualStyleBackColor = true;
            this.TrackerButton.Click += new System.EventHandler(this.TrackerButton_Click);
            // 
            // RemindersButton
            // 
            this.RemindersButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemindersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemindersButton.Location = new System.Drawing.Point(32, 320);
            this.RemindersButton.Name = "RemindersButton";
            this.RemindersButton.Size = new System.Drawing.Size(160, 60);
            this.RemindersButton.TabIndex = 4;
            this.RemindersButton.Text = "Reminders";
            this.RemindersButton.UseVisualStyleBackColor = true;
            this.RemindersButton.Click += new System.EventHandler(this.RemindersButton_Click);
            // 
            // CatalystMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 401);
            this.Controls.Add(this.RemindersButton);
            this.Controls.Add(this.TrackerButton);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.PomodoroButton);
            this.Controls.Add(this.TodoButton);
            this.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(240, 440);
            this.MinimumSize = new System.Drawing.Size(240, 440);
            this.Name = "CatalystMain";
            this.Text = "Catalyst | Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TodoButton;
        private System.Windows.Forms.Button PomodoroButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button TrackerButton;
        private System.Windows.Forms.Button RemindersButton;
    }
}

