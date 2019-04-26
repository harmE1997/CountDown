namespace CountDown
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.gbCountTo = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbSpecificTime = new System.Windows.Forms.GroupBox();
            this.lblSecs = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCountSpecific = new System.Windows.Forms.Button();
            this.nudSecs = new System.Windows.Forms.NumericUpDown();
            this.nudMins = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.btnResume = new System.Windows.Forms.Button();
            this.gbCountTo.SuspendLayout();
            this.gbSpecificTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(61, 82);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Countdown";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.countDown);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStop.AutoSize = true;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(398, 24);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(281, 28);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Pause Countdown";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(61, 22);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(228, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(61, 52);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(228, 22);
            this.dtpTime.TabIndex = 4;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDown.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(189, 445);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(92, 37);
            this.lblCountDown.TabIndex = 5;
            this.lblCountDown.Text = "label1";
            // 
            // gbCountTo
            // 
            this.gbCountTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbCountTo.AutoSize = true;
            this.gbCountTo.BackColor = System.Drawing.Color.Transparent;
            this.gbCountTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCountTo.Controls.Add(this.lblTime);
            this.gbCountTo.Controls.Add(this.lblDate);
            this.gbCountTo.Controls.Add(this.dtpDate);
            this.gbCountTo.Controls.Add(this.dtpTime);
            this.gbCountTo.Controls.Add(this.btnStart);
            this.gbCountTo.ForeColor = System.Drawing.Color.White;
            this.gbCountTo.Location = new System.Drawing.Point(12, 151);
            this.gbCountTo.Name = "gbCountTo";
            this.gbCountTo.Size = new System.Drawing.Size(300, 161);
            this.gbCountTo.TabIndex = 6;
            this.gbCountTo.TabStop = false;
            this.gbCountTo.Text = "Count Down To";
            this.gbCountTo.Enter += new System.EventHandler(this.gbCountTo_Enter);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(16, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(16, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // gbSpecificTime
            // 
            this.gbSpecificTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbSpecificTime.AutoSize = true;
            this.gbSpecificTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSpecificTime.BackColor = System.Drawing.Color.Transparent;
            this.gbSpecificTime.Controls.Add(this.lblSecs);
            this.gbSpecificTime.Controls.Add(this.lblMins);
            this.gbSpecificTime.Controls.Add(this.lblHours);
            this.gbSpecificTime.Controls.Add(this.lblDays);
            this.gbSpecificTime.Controls.Add(this.btnCountSpecific);
            this.gbSpecificTime.Controls.Add(this.nudSecs);
            this.gbSpecificTime.Controls.Add(this.nudMins);
            this.gbSpecificTime.Controls.Add(this.nudHours);
            this.gbSpecificTime.Controls.Add(this.nudDays);
            this.gbSpecificTime.ForeColor = System.Drawing.Color.White;
            this.gbSpecificTime.Location = new System.Drawing.Point(784, 151);
            this.gbSpecificTime.Name = "gbSpecificTime";
            this.gbSpecificTime.Size = new System.Drawing.Size(248, 180);
            this.gbSpecificTime.TabIndex = 7;
            this.gbSpecificTime.TabStop = false;
            this.gbSpecificTime.Text = "Count Down Specific Time";
            // 
            // lblSecs
            // 
            this.lblSecs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSecs.AutoSize = true;
            this.lblSecs.Location = new System.Drawing.Point(13, 107);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(63, 17);
            this.lblSecs.TabIndex = 8;
            this.lblSecs.Text = "Seconds";
            // 
            // lblMins
            // 
            this.lblMins.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(13, 79);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(57, 17);
            this.lblMins.TabIndex = 7;
            this.lblMins.Text = "Minutes";
            // 
            // lblHours
            // 
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(13, 51);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(46, 17);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours";
            // 
            // lblDays
            // 
            this.lblDays.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(13, 23);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(40, 17);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "Days";
            // 
            // btnCountSpecific
            // 
            this.btnCountSpecific.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCountSpecific.AutoSize = true;
            this.btnCountSpecific.ForeColor = System.Drawing.Color.Black;
            this.btnCountSpecific.Location = new System.Drawing.Point(6, 132);
            this.btnCountSpecific.Name = "btnCountSpecific";
            this.btnCountSpecific.Size = new System.Drawing.Size(236, 27);
            this.btnCountSpecific.TabIndex = 4;
            this.btnCountSpecific.Text = "Start Countdown";
            this.btnCountSpecific.UseVisualStyleBackColor = true;
            this.btnCountSpecific.Click += new System.EventHandler(this.btnCountSpecific_Click);
            // 
            // nudSecs
            // 
            this.nudSecs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudSecs.AutoSize = true;
            this.nudSecs.Location = new System.Drawing.Point(82, 105);
            this.nudSecs.Name = "nudSecs";
            this.nudSecs.Size = new System.Drawing.Size(160, 22);
            this.nudSecs.TabIndex = 3;
            // 
            // nudMins
            // 
            this.nudMins.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudMins.AutoSize = true;
            this.nudMins.Location = new System.Drawing.Point(82, 77);
            this.nudMins.Name = "nudMins";
            this.nudMins.Size = new System.Drawing.Size(160, 22);
            this.nudMins.TabIndex = 2;
            // 
            // nudHours
            // 
            this.nudHours.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudHours.AutoSize = true;
            this.nudHours.Location = new System.Drawing.Point(82, 49);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(160, 22);
            this.nudHours.TabIndex = 1;
            // 
            // nudDays
            // 
            this.nudDays.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudDays.AutoSize = true;
            this.nudDays.Location = new System.Drawing.Point(82, 21);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(160, 22);
            this.nudDays.TabIndex = 0;
            // 
            // btnResume
            // 
            this.btnResume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResume.AutoSize = true;
            this.btnResume.Location = new System.Drawing.Point(398, 59);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(281, 33);
            this.btnResume.TabIndex = 8;
            this.btnResume.Text = "Resume Countdown";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 554);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.gbSpecificTime);
            this.Controls.Add(this.gbCountTo);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.btnStop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "JSF Final Countdown";
            this.gbCountTo.ResumeLayout(false);
            this.gbCountTo.PerformLayout();
            this.gbSpecificTime.ResumeLayout(false);
            this.gbSpecificTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.GroupBox gbCountTo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbSpecificTime;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnCountSpecific;
        private System.Windows.Forms.NumericUpDown nudSecs;
        private System.Windows.Forms.NumericUpDown nudMins;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Button btnResume;
    }
}

