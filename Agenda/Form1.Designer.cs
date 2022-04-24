namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Monday = new System.Windows.Forms.Button();
            this.Tuesday = new System.Windows.Forms.Button();
            this.Wednesday = new System.Windows.Forms.Button();
            this.Thursday = new System.Windows.Forms.Button();
            this.Friday = new System.Windows.Forms.Button();
            this.Saturday = new System.Windows.Forms.Button();
            this.Sunday = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(319, 239);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(319, 24);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 3;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(565, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 379);
            this.listBox1.TabIndex = 4;
            // 
            // Monday
            // 
            this.Monday.Location = new System.Drawing.Point(-10, 22);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(75, 23);
            this.Monday.TabIndex = 5;
            this.Monday.Text = "Pazartesi";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.Location = new System.Drawing.Point(86, 22);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(75, 23);
            this.Tuesday.TabIndex = 6;
            this.Tuesday.Text = "Salı";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.Location = new System.Drawing.Point(183, 22);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(75, 23);
            this.Wednesday.TabIndex = 7;
            this.Wednesday.Text = "Çarşamba";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(34, 63);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(75, 23);
            this.Thursday.TabIndex = 8;
            this.Thursday.Text = "Perşembe";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.Location = new System.Drawing.Point(136, 63);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(75, 23);
            this.Friday.TabIndex = 9;
            this.Friday.Text = "Cuma";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Saturday
            // 
            this.Saturday.Location = new System.Drawing.Point(-12, 105);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(75, 23);
            this.Saturday.TabIndex = 10;
            this.Saturday.Text = "Cumartesi";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Sunday
            // 
            this.Sunday.Location = new System.Drawing.Point(181, 105);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(75, 23);
            this.Sunday.TabIndex = 11;
            this.Sunday.Text = "Pazar";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sunday);
            this.groupBox1.Controls.Add(this.Thursday);
            this.groupBox1.Controls.Add(this.Monday);
            this.groupBox1.Controls.Add(this.Wednesday);
            this.groupBox1.Controls.Add(this.Friday);
            this.groupBox1.Controls.Add(this.Saturday);
            this.groupBox1.Controls.Add(this.Tuesday);
            this.groupBox1.Location = new System.Drawing.Point(21, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private ListBox listBox1;
        private Button Monday;
        private Button Tuesday;
        private Button Wednesday;
        private Button Thursday;
        private Button Friday;
        private Button Saturday;
        private Button Sunday;
        private GroupBox groupBox1;
    }
}