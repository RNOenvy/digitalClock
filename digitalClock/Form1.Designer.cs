namespace digitalClock
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
            this.hourMinuteLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weekDayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hourMinuteLabel
            // 
            this.hourMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hourMinuteLabel.Location = new System.Drawing.Point(74, 71);
            this.hourMinuteLabel.Name = "hourMinuteLabel";
            this.hourMinuteLabel.Size = new System.Drawing.Size(203, 69);
            this.hourMinuteLabel.TabIndex = 0;
            this.hourMinuteLabel.Text = "19 : 25";
            // 
            // secondsLabel
            // 
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondsLabel.Location = new System.Drawing.Point(317, 71);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(203, 69);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "47";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateLabel.Location = new System.Drawing.Point(74, 154);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(435, 68);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Jan 03 2017";
            // 
            // weekDayLabel
            // 
            this.weekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weekDayLabel.Location = new System.Drawing.Point(88, 233);
            this.weekDayLabel.Name = "weekDayLabel";
            this.weekDayLabel.Size = new System.Drawing.Size(314, 69);
            this.weekDayLabel.TabIndex = 3;
            this.weekDayLabel.Text = "19 : 25";
            this.weekDayLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.weekDayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hourMinuteLabel);
            this.Name = "Form1";
            this.Text = "Dans Tima & Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinuteLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weekDayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

