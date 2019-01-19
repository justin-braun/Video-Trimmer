namespace VideoTrimmer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.buttonBrowseSource = new System.Windows.Forms.Button();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStartMinute = new System.Windows.Forms.TextBox();
            this.textBoxStartSecond = new System.Windows.Forms.TextBox();
            this.textBoxEndSecond = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEndMinute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEndHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File:";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(19, 30);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(285, 20);
            this.textBoxSourceFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output File:";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(19, 74);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(285, 20);
            this.textBoxOutputFile.TabIndex = 3;
            // 
            // buttonBrowseSource
            // 
            this.buttonBrowseSource.Location = new System.Drawing.Point(310, 29);
            this.buttonBrowseSource.Name = "buttonBrowseSource";
            this.buttonBrowseSource.Size = new System.Drawing.Size(24, 23);
            this.buttonBrowseSource.TabIndex = 4;
            this.buttonBrowseSource.Text = "...";
            this.buttonBrowseSource.UseVisualStyleBackColor = true;
            this.buttonBrowseSource.Click += new System.EventHandler(this.buttonBrowseSource_Click);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Location = new System.Drawing.Point(310, 72);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(24, 23);
            this.buttonBrowseDestination.TabIndex = 5;
            this.buttonBrowseDestination.Text = "...";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Trim:";
            // 
            // textBoxStartHour
            // 
            this.textBoxStartHour.Location = new System.Drawing.Point(19, 118);
            this.textBoxStartHour.MaxLength = 2;
            this.textBoxStartHour.Name = "textBoxStartHour";
            this.textBoxStartHour.Size = new System.Drawing.Size(35, 20);
            this.textBoxStartHour.TabIndex = 7;
            this.textBoxStartHour.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // textBoxStartMinute
            // 
            this.textBoxStartMinute.Location = new System.Drawing.Point(70, 118);
            this.textBoxStartMinute.MaxLength = 2;
            this.textBoxStartMinute.Name = "textBoxStartMinute";
            this.textBoxStartMinute.Size = new System.Drawing.Size(35, 20);
            this.textBoxStartMinute.TabIndex = 10;
            this.textBoxStartMinute.Text = "00";
            // 
            // textBoxStartSecond
            // 
            this.textBoxStartSecond.Location = new System.Drawing.Point(121, 118);
            this.textBoxStartSecond.MaxLength = 2;
            this.textBoxStartSecond.Name = "textBoxStartSecond";
            this.textBoxStartSecond.Size = new System.Drawing.Size(35, 20);
            this.textBoxStartSecond.TabIndex = 12;
            this.textBoxStartSecond.Text = "00";
            // 
            // textBoxEndSecond
            // 
            this.textBoxEndSecond.Location = new System.Drawing.Point(299, 118);
            this.textBoxEndSecond.MaxLength = 2;
            this.textBoxEndSecond.Name = "textBoxEndSecond";
            this.textBoxEndSecond.Size = new System.Drawing.Size(35, 20);
            this.textBoxEndSecond.TabIndex = 18;
            this.textBoxEndSecond.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = ":";
            // 
            // textBoxEndMinute
            // 
            this.textBoxEndMinute.Location = new System.Drawing.Point(248, 118);
            this.textBoxEndMinute.MaxLength = 2;
            this.textBoxEndMinute.Name = "textBoxEndMinute";
            this.textBoxEndMinute.Size = new System.Drawing.Size(35, 20);
            this.textBoxEndMinute.TabIndex = 16;
            this.textBoxEndMinute.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // textBoxEndHour
            // 
            this.textBoxEndHour.Location = new System.Drawing.Point(197, 118);
            this.textBoxEndHour.MaxLength = 2;
            this.textBoxEndHour.Name = "textBoxEndHour";
            this.textBoxEndHour.Size = new System.Drawing.Size(35, 20);
            this.textBoxEndHour.TabIndex = 14;
            this.textBoxEndHour.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "End Trim:";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(19, 155);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(315, 23);
            this.progressBarMain.TabIndex = 19;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(135, 313);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(315, 110);
            this.textBox1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 348);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.textBoxEndSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEndMinute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEndHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStartSecond);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStartMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStartHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.buttonBrowseSource);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSourceFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Trimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Button buttonBrowseSource;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStartMinute;
        private System.Windows.Forms.TextBox textBoxStartSecond;
        private System.Windows.Forms.TextBox textBoxEndSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEndMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEndHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
    }
}

