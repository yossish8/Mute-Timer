namespace mute_test
{
    partial class Form1
    {
        /// <summary>
        /// mostly auto generated code of Form1(=main window)
        /// timerSeconds is the total amount of seconds until mute.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int timerSeconds = -1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oneSecTick = new System.Windows.Forms.Timer(this.components);
            this.inputMinutes = new System.Windows.Forms.NumericUpDown();
            this.countdown = new System.Windows.Forms.Label();
            this.inputHours = new System.Windows.Forms.NumericUpDown();
            this.hoursLable = new System.Windows.Forms.Label();
            this.minutesLable = new System.Windows.Forms.Label();
            this.timeRemainsLable = new System.Windows.Forms.Label();
            this.willMuteAtLable = new System.Windows.Forms.Label();
            this.muteAtOclockLable = new System.Windows.Forms.Label();
            this.specifyHourLable = new System.Windows.Forms.Label();
            this.specifyHour = new System.Windows.Forms.NumericUpDown();
            this.specifyMinute = new System.Windows.Forms.NumericUpDown();
            this.specifyHoursLable = new System.Windows.Forms.Label();
            this.specifyMinuteLable = new System.Windows.Forms.Label();
            this.setTimerLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifyHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifyMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // oneSecTick
            // 
            this.oneSecTick.Enabled = true;
            this.oneSecTick.Interval = 1000;
            this.oneSecTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputMinutes
            // 
            this.inputMinutes.Location = new System.Drawing.Point(243, 10);
            this.inputMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.inputMinutes.Name = "inputMinutes";
            this.inputMinutes.Size = new System.Drawing.Size(40, 20);
            this.inputMinutes.TabIndex = 2;
            this.inputMinutes.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Location = new System.Drawing.Point(148, 42);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(0, 13);
            this.countdown.TabIndex = 3;
            // 
            // inputHours
            // 
            this.inputHours.Location = new System.Drawing.Point(176, 10);
            this.inputHours.Name = "inputHours";
            this.inputHours.Size = new System.Drawing.Size(40, 20);
            this.inputHours.TabIndex = 4;
            this.inputHours.ValueChanged += new System.EventHandler(this.inputHours_ValueChanged);
            // 
            // hoursLable
            // 
            this.hoursLable.AutoSize = true;
            this.hoursLable.Location = new System.Drawing.Point(222, 17);
            this.hoursLable.Name = "hoursLable";
            this.hoursLable.Size = new System.Drawing.Size(15, 13);
            this.hoursLable.TabIndex = 5;
            this.hoursLable.Text = "H";
            // 
            // minutesLable
            // 
            this.minutesLable.AutoSize = true;
            this.minutesLable.Location = new System.Drawing.Point(289, 17);
            this.minutesLable.Name = "minutesLable";
            this.minutesLable.Size = new System.Drawing.Size(16, 13);
            this.minutesLable.TabIndex = 6;
            this.minutesLable.Text = "M";
            // 
            // timeRemainsLable
            // 
            this.timeRemainsLable.AutoSize = true;
            this.timeRemainsLable.Location = new System.Drawing.Point(4, 42);
            this.timeRemainsLable.Name = "timeRemainsLable";
            this.timeRemainsLable.Size = new System.Drawing.Size(80, 13);
            this.timeRemainsLable.TabIndex = 7;
            this.timeRemainsLable.Text = "Time Remining:";
            // 
            // willMuteAtLable
            // 
            this.willMuteAtLable.AutoSize = true;
            this.willMuteAtLable.Location = new System.Drawing.Point(4, 65);
            this.willMuteAtLable.Name = "willMuteAtLable";
            this.willMuteAtLable.Size = new System.Drawing.Size(67, 13);
            this.willMuteAtLable.TabIndex = 8;
            this.willMuteAtLable.Text = "Will Mute At:";
            // 
            // muteAtOclockLable
            // 
            this.muteAtOclockLable.AutoSize = true;
            this.muteAtOclockLable.Location = new System.Drawing.Point(148, 65);
            this.muteAtOclockLable.Name = "muteAtOclockLable";
            this.muteAtOclockLable.Size = new System.Drawing.Size(0, 13);
            this.muteAtOclockLable.TabIndex = 9;
            // 
            // specifyHourLable
            // 
            this.specifyHourLable.AutoSize = true;
            this.specifyHourLable.Location = new System.Drawing.Point(4, 94);
            this.specifyHourLable.Name = "specifyHourLable";
            this.specifyHourLable.Size = new System.Drawing.Size(158, 13);
            this.specifyHourLable.TabIndex = 10;
            this.specifyHourLable.Text = "Or Specify Exact Hour To Mute:";
            // 
            // specifyHour
            // 
            this.specifyHour.Location = new System.Drawing.Point(176, 87);
            this.specifyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.specifyHour.Name = "specifyHour";
            this.specifyHour.Size = new System.Drawing.Size(40, 20);
            this.specifyHour.TabIndex = 11;
            this.specifyHour.ValueChanged += new System.EventHandler(this.specifyHour_ValueChanged);
            // 
            // specifyMinute
            // 
            this.specifyMinute.Location = new System.Drawing.Point(243, 87);
            this.specifyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.specifyMinute.Name = "specifyMinute";
            this.specifyMinute.Size = new System.Drawing.Size(40, 20);
            this.specifyMinute.TabIndex = 12;
            this.specifyMinute.ValueChanged += new System.EventHandler(this.specifyMinute_ValueChanged);
            // 
            // specifyHoursLable
            // 
            this.specifyHoursLable.AutoSize = true;
            this.specifyHoursLable.Location = new System.Drawing.Point(222, 94);
            this.specifyHoursLable.Name = "specifyHoursLable";
            this.specifyHoursLable.Size = new System.Drawing.Size(15, 13);
            this.specifyHoursLable.TabIndex = 13;
            this.specifyHoursLable.Text = "H";
            // 
            // specifyMinuteLable
            // 
            this.specifyMinuteLable.AutoSize = true;
            this.specifyMinuteLable.Location = new System.Drawing.Point(289, 94);
            this.specifyMinuteLable.Name = "specifyMinuteLable";
            this.specifyMinuteLable.Size = new System.Drawing.Size(16, 13);
            this.specifyMinuteLable.TabIndex = 14;
            this.specifyMinuteLable.Text = "M";
            // 
            // setTimerLable
            // 
            this.setTimerLable.AutoSize = true;
            this.setTimerLable.Location = new System.Drawing.Point(4, 17);
            this.setTimerLable.Name = "setTimerLable";
            this.setTimerLable.Size = new System.Drawing.Size(55, 13);
            this.setTimerLable.TabIndex = 15;
            this.setTimerLable.Text = "Set Timer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(308, 115);
            this.Controls.Add(this.setTimerLable);
            this.Controls.Add(this.specifyMinuteLable);
            this.Controls.Add(this.specifyHoursLable);
            this.Controls.Add(this.specifyMinute);
            this.Controls.Add(this.specifyHour);
            this.Controls.Add(this.specifyHourLable);
            this.Controls.Add(this.muteAtOclockLable);
            this.Controls.Add(this.willMuteAtLable);
            this.Controls.Add(this.timeRemainsLable);
            this.Controls.Add(this.minutesLable);
            this.Controls.Add(this.hoursLable);
            this.Controls.Add(this.inputHours);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.inputMinutes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mute Timer";
            ((System.ComponentModel.ISupportInitialize)(this.inputMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifyHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifyMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer oneSecTick;
        private System.Windows.Forms.NumericUpDown inputMinutes;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.NumericUpDown inputHours;
        private System.Windows.Forms.Label hoursLable;
        private System.Windows.Forms.Label minutesLable;
        private System.Windows.Forms.Label timeRemainsLable;
        private System.Windows.Forms.Label willMuteAtLable;
        private System.Windows.Forms.Label muteAtOclockLable;
        private System.Windows.Forms.Label specifyHourLable;
        private System.Windows.Forms.NumericUpDown specifyHour;
        private System.Windows.Forms.NumericUpDown specifyMinute;
        private System.Windows.Forms.Label specifyHoursLable;
        private System.Windows.Forms.Label specifyMinuteLable;
        private System.Windows.Forms.Label setTimerLable;
    }
}

