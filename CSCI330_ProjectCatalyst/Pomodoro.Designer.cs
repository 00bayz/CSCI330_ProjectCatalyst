
namespace CSCI330_ProjectCatalyst
{
    partial class Pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox PomTimerBox;
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BtnPauseResume = new System.Windows.Forms.Button();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.PomTimerDisplayLabel = new System.Windows.Forms.Label();
            this.PomSettingsBox = new System.Windows.Forms.GroupBox();
            this.SetIntervalNUD = new System.Windows.Forms.NumericUpDown();
            this.SetIntervalLabel = new System.Windows.Forms.Label();
            this.SetLongNUD = new System.Windows.Forms.NumericUpDown();
            this.SetLongLabel = new System.Windows.Forms.Label();
            this.SetShortNUD = new System.Windows.Forms.NumericUpDown();
            this.SetShortLabel = new System.Windows.Forms.Label();
            this.SetPomNUD = new System.Windows.Forms.NumericUpDown();
            this.SetPomLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            PomTimerBox = new System.Windows.Forms.GroupBox();
            PomTimerBox.SuspendLayout();
            this.PomSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetIntervalNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLongNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetShortNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPomNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // PomTimerBox
            // 
            PomTimerBox.Controls.Add(this.StatusLabel);
            PomTimerBox.Controls.Add(this.BtnPauseResume);
            PomTimerBox.Controls.Add(this.BtnStartStop);
            PomTimerBox.Controls.Add(this.PomTimerDisplayLabel);
            PomTimerBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            PomTimerBox.Location = new System.Drawing.Point(13, 13);
            PomTimerBox.Margin = new System.Windows.Forms.Padding(4);
            PomTimerBox.Name = "PomTimerBox";
            PomTimerBox.Padding = new System.Windows.Forms.Padding(4);
            PomTimerBox.Size = new System.Drawing.Size(420, 495);
            PomTimerBox.TabIndex = 0;
            PomTimerBox.TabStop = false;
            PomTimerBox.Text = "Pomodoro Timer";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(7, 205);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(407, 20);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Pomodoro";
            this.StatusLabel.Visible = false;
            // 
            // BtnPauseResume
            // 
            this.BtnPauseResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPauseResume.Location = new System.Drawing.Point(7, 274);
            this.BtnPauseResume.Name = "BtnPauseResume";
            this.BtnPauseResume.Size = new System.Drawing.Size(407, 40);
            this.BtnPauseResume.TabIndex = 2;
            this.BtnPauseResume.Text = "Pause";
            this.BtnPauseResume.UseVisualStyleBackColor = true;
            this.BtnPauseResume.Visible = false;
            this.BtnPauseResume.Click += new System.EventHandler(this.BtnPauseResume_Click);
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnStartStop.Location = new System.Drawing.Point(7, 228);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(407, 40);
            this.BtnStartStop.TabIndex = 1;
            this.BtnStartStop.Text = "Start";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // PomTimerDisplayLabel
            // 
            this.PomTimerDisplayLabel.AutoSize = true;
            this.PomTimerDisplayLabel.Font = new System.Drawing.Font("Liberation Mono", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomTimerDisplayLabel.Location = new System.Drawing.Point(2, 80);
            this.PomTimerDisplayLabel.Name = "PomTimerDisplayLabel";
            this.PomTimerDisplayLabel.Size = new System.Drawing.Size(417, 136);
            this.PomTimerDisplayLabel.TabIndex = 0;
            this.PomTimerDisplayLabel.Text = "25:00";
            // 
            // PomSettingsBox
            // 
            this.PomSettingsBox.Controls.Add(this.SetIntervalNUD);
            this.PomSettingsBox.Controls.Add(this.SetIntervalLabel);
            this.PomSettingsBox.Controls.Add(this.SetLongNUD);
            this.PomSettingsBox.Controls.Add(this.SetLongLabel);
            this.PomSettingsBox.Controls.Add(this.SetShortNUD);
            this.PomSettingsBox.Controls.Add(this.SetShortLabel);
            this.PomSettingsBox.Controls.Add(this.SetPomNUD);
            this.PomSettingsBox.Controls.Add(this.SetPomLabel);
            this.PomSettingsBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PomSettingsBox.Location = new System.Drawing.Point(440, 13);
            this.PomSettingsBox.Name = "PomSettingsBox";
            this.PomSettingsBox.Size = new System.Drawing.Size(252, 495);
            this.PomSettingsBox.TabIndex = 1;
            this.PomSettingsBox.TabStop = false;
            this.PomSettingsBox.Text = "Settings";
            // 
            // SetIntervalNUD
            // 
            this.SetIntervalNUD.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetIntervalNUD.Location = new System.Drawing.Point(36, 400);
            this.SetIntervalNUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SetIntervalNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetIntervalNUD.Name = "SetIntervalNUD";
            this.SetIntervalNUD.Size = new System.Drawing.Size(180, 31);
            this.SetIntervalNUD.TabIndex = 7;
            this.SetIntervalNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetIntervalNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetIntervalNUD.ValueChanged += new System.EventHandler(this.SetIntervalNUD_ValueChanged);
            // 
            // SetIntervalLabel
            // 
            this.SetIntervalLabel.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetIntervalLabel.Location = new System.Drawing.Point(6, 370);
            this.SetIntervalLabel.Name = "SetIntervalLabel";
            this.SetIntervalLabel.Size = new System.Drawing.Size(240, 20);
            this.SetIntervalLabel.TabIndex = 6;
            this.SetIntervalLabel.Text = "Interval";
            this.SetIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetLongNUD
            // 
            this.SetLongNUD.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLongNUD.Location = new System.Drawing.Point(36, 290);
            this.SetLongNUD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SetLongNUD.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SetLongNUD.Name = "SetLongNUD";
            this.SetLongNUD.Size = new System.Drawing.Size(180, 31);
            this.SetLongNUD.TabIndex = 5;
            this.SetLongNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetLongNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SetLongNUD.ValueChanged += new System.EventHandler(this.SetLongNUD_ValueChanged);
            // 
            // SetLongLabel
            // 
            this.SetLongLabel.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLongLabel.Location = new System.Drawing.Point(6, 260);
            this.SetLongLabel.Name = "SetLongLabel";
            this.SetLongLabel.Size = new System.Drawing.Size(240, 20);
            this.SetLongLabel.TabIndex = 4;
            this.SetLongLabel.Text = "Long Break";
            this.SetLongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetShortNUD
            // 
            this.SetShortNUD.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetShortNUD.Location = new System.Drawing.Point(36, 180);
            this.SetShortNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SetShortNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SetShortNUD.Name = "SetShortNUD";
            this.SetShortNUD.Size = new System.Drawing.Size(180, 31);
            this.SetShortNUD.TabIndex = 3;
            this.SetShortNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetShortNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SetShortNUD.ValueChanged += new System.EventHandler(this.SetShortNUD_ValueChanged);
            // 
            // SetShortLabel
            // 
            this.SetShortLabel.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetShortLabel.Location = new System.Drawing.Point(6, 150);
            this.SetShortLabel.Name = "SetShortLabel";
            this.SetShortLabel.Size = new System.Drawing.Size(240, 20);
            this.SetShortLabel.TabIndex = 2;
            this.SetShortLabel.Text = "Short Break";
            this.SetShortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetPomNUD
            // 
            this.SetPomNUD.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPomNUD.Location = new System.Drawing.Point(36, 70);
            this.SetPomNUD.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.SetPomNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetPomNUD.Name = "SetPomNUD";
            this.SetPomNUD.Size = new System.Drawing.Size(180, 31);
            this.SetPomNUD.TabIndex = 1;
            this.SetPomNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetPomNUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SetPomNUD.TextChanged += new System.EventHandler(this.SetPomNUD_TextChanged);
            this.SetPomNUD.ValueChanged += new System.EventHandler(this.SetPomNUD_ValueChanged);
            // 
            // SetPomLabel
            // 
            this.SetPomLabel.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPomLabel.Location = new System.Drawing.Point(6, 40);
            this.SetPomLabel.Name = "SetPomLabel";
            this.SetPomLabel.Size = new System.Drawing.Size(240, 20);
            this.SetPomLabel.TabIndex = 0;
            this.SetPomLabel.Text = "Pomodoro\r\n";
            this.SetPomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.PomSettingsBox);
            this.Controls.Add(PomTimerBox);
            this.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(720, 560);
            this.MinimumSize = new System.Drawing.Size(720, 560);
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            PomTimerBox.ResumeLayout(false);
            PomTimerBox.PerformLayout();
            this.PomSettingsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SetIntervalNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLongNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetShortNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPomNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PomSettingsBox;
        private System.Windows.Forms.Label PomTimerDisplayLabel;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.Button BtnPauseResume;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label SetShortLabel;
        private System.Windows.Forms.NumericUpDown SetPomNUD;
        private System.Windows.Forms.Label SetPomLabel;
        private System.Windows.Forms.NumericUpDown SetIntervalNUD;
        private System.Windows.Forms.Label SetIntervalLabel;
        private System.Windows.Forms.NumericUpDown SetLongNUD;
        private System.Windows.Forms.Label SetLongLabel;
        private System.Windows.Forms.NumericUpDown SetShortNUD;
    }
}