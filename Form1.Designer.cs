namespace Timer
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxSnoozeTime = new System.Windows.Forms.CheckBox();
            this.selectSound = new System.Windows.Forms.Button();
            this.comboBoxSelectSound = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(37, 31);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 23);
            this.dateTimePicker.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(29, 138);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 28);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(74, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status...";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(110, 138);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 28);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // checkBoxSnoozeTime
            // 
            this.checkBoxSnoozeTime.AutoSize = true;
            this.checkBoxSnoozeTime.Location = new System.Drawing.Point(29, 173);
            this.checkBoxSnoozeTime.Name = "checkBoxSnoozeTime";
            this.checkBoxSnoozeTime.Size = new System.Drawing.Size(61, 20);
            this.checkBoxSnoozeTime.TabIndex = 4;
            this.checkBoxSnoozeTime.Text = "Snooze";
            this.checkBoxSnoozeTime.UseVisualStyleBackColor = true;
            // 
            // selectSound
            // 
            this.selectSound.Location = new System.Drawing.Point(199, 33);
            this.selectSound.Name = "selectSound";
            this.selectSound.Size = new System.Drawing.Size(28, 23);
            this.selectSound.TabIndex = 5;
            this.selectSound.Text = "...";
            this.selectSound.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelectSound
            // 
            this.comboBoxSelectSound.AllowDrop = true;
            this.comboBoxSelectSound.FormattingEnabled = true;
            this.comboBoxSelectSound.Location = new System.Drawing.Point(111, 62);
            this.comboBoxSelectSound.Name = "comboBoxSelectSound";
            this.comboBoxSelectSound.Size = new System.Drawing.Size(109, 24);
            this.comboBoxSelectSound.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Sound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(231, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectSound);
            this.Controls.Add(this.selectSound);
            this.Controls.Add(this.checkBoxSnoozeTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dateTimePicker);
            this.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxSnoozeTime;
        private System.Windows.Forms.Button selectSound;
        private System.Windows.Forms.ComboBox comboBoxSelectSound;
        private System.Windows.Forms.Label label1;
    }
}

