namespace HebrewDate
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
            this.btnCreateDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbDayMonth = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblFinalHebrewDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateDate
            // 
            this.btnCreateDate.Location = new System.Drawing.Point(12, 201);
            this.btnCreateDate.Name = "btnCreateDate";
            this.btnCreateDate.Size = new System.Drawing.Size(111, 43);
            this.btnCreateDate.TabIndex = 0;
            this.btnCreateDate.Text = "כתיבה";
            this.btnCreateDate.UseVisualStyleBackColor = true;
            this.btnCreateDate.Click += new System.EventHandler(this.btnCreateDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "שנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "חודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "היום בחודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "היום בשבוע";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "תשפ\'\'ד",
            "תשפ\'\'ה",
            "תשפ\'\'ו",
            "תשפ\'\'ז",
            "תשפ\'\'ח",
            "תשפ\'\'ט",
            "תש\'\'צ",
            "תשצ\'\'א",
            "תשצ\'\'ב",
            "תשצ\'\'ג"});
            this.cmbYear.Location = new System.Drawing.Point(168, 100);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 21);
            this.cmbYear.TabIndex = 6;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.cmbDay.Location = new System.Drawing.Point(630, 100);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(100, 21);
            this.cmbDay.TabIndex = 7;
            // 
            // cmbDayMonth
            // 
            this.cmbDayMonth.FormattingEnabled = true;
            this.cmbDayMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDayMonth.Location = new System.Drawing.Point(477, 100);
            this.cmbDayMonth.Name = "cmbDayMonth";
            this.cmbDayMonth.Size = new System.Drawing.Size(100, 21);
            this.cmbDayMonth.TabIndex = 8;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMonth.Location = new System.Drawing.Point(320, 100);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(100, 21);
            this.cmbMonth.TabIndex = 9;
            // 
            // lblFinalHebrewDate
            // 
            this.lblFinalHebrewDate.AutoSize = true;
            this.lblFinalHebrewDate.Location = new System.Drawing.Point(165, 322);
            this.lblFinalHebrewDate.Name = "lblFinalHebrewDate";
            this.lblFinalHebrewDate.Size = new System.Drawing.Size(67, 13);
            this.lblFinalHebrewDate.TabIndex = 10;
            this.lblFinalHebrewDate.Text = "תאריך סופי";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinalHebrewDate);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDayMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbDayMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblFinalHebrewDate;
    }
}

