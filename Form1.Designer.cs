namespace StudentRegistrationApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lnameTextBox = new TextBox();
            fnameTextBox = new TextBox();
            mnameTextBox = new TextBox();
            Day = new ComboBox();
            Month = new ComboBox();
            Year = new ComboBox();
            isMale = new RadioButton();
            isFemale = new RadioButton();
            selectProgram = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-5, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 106);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 167);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Middle Name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 226);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 250);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 5;
            label6.Text = "Date of Birth *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 307);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 6;
            label7.Text = "Program to Apply *";
            // 
            // lnameTextBox
            // 
            lnameTextBox.Location = new Point(27, 69);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(264, 27);
            lnameTextBox.TabIndex = 7;
            lnameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(27, 129);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(264, 27);
            fnameTextBox.TabIndex = 8;
            fnameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // mnameTextBox
            // 
            mnameTextBox.Location = new Point(27, 190);
            mnameTextBox.Name = "mnameTextBox";
            mnameTextBox.Size = new Size(264, 27);
            mnameTextBox.TabIndex = 9;
            mnameTextBox.TextChanged += textBox3_TextChanged;
            // 
            // Day
            // 
            Day.Font = new Font("Segoe UI", 9F);
            Day.FormattingEnabled = true;
            Day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            Day.Location = new Point(27, 276);
            Day.Name = "Day";
            Day.Size = new Size(67, 28);
            Day.TabIndex = 10;
            Day.Text = "-Day-";
            Day.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Month
            // 
            Month.Font = new Font("Segoe UI", 9F);
            Month.FormattingEnabled = true;
            Month.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            Month.Location = new Point(100, 276);
            Month.Name = "Month";
            Month.Size = new Size(99, 28);
            Month.TabIndex = 11;
            Month.Text = "-Month-";
            Month.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Year
            // 
            Year.Font = new Font("Segoe UI", 9F);
            Year.FormattingEnabled = true;
            Year.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            Year.Location = new Point(203, 276);
            Year.Name = "Year";
            Year.Size = new Size(88, 28);
            Year.TabIndex = 12;
            Year.Text = "-Year-";
            Year.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // isMale
            // 
            isMale.AutoSize = true;
            isMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isMale.Location = new Point(114, 225);
            isMale.Name = "isMale";
            isMale.Size = new Size(64, 24);
            isMale.TabIndex = 13;
            isMale.TabStop = true;
            isMale.Text = "Male";
            isMale.UseVisualStyleBackColor = true;
            isMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // isFemale
            // 
            isFemale.AutoSize = true;
            isFemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isFemale.Location = new Point(183, 225);
            isFemale.Name = "isFemale";
            isFemale.Size = new Size(79, 24);
            isFemale.TabIndex = 14;
            isFemale.TabStop = true;
            isFemale.Text = "Female";
            isFemale.UseVisualStyleBackColor = true;
            isFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // selectProgram
            // 
            selectProgram.FormattingEnabled = true;
            selectProgram.Items.AddRange(new object[] { "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Tourism Management (BSTM)", "Bachelor of Science in Nursing (BSN)", "Bachelor of Multimedia Arts (BMMA)" });
            selectProgram.Location = new Point(27, 330);
            selectProgram.Name = "selectProgram";
            selectProgram.Size = new Size(356, 28);
            selectProgram.TabIndex = 15;
            selectProgram.Text = "-Select Program-";
            selectProgram.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(27, 364);
            button1.Name = "button1";
            button1.Size = new Size(172, 44);
            button1.TabIndex = 16;
            button1.Text = "Register Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(359, 265);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 17;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(314, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 213);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 420);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(selectProgram);
            Controls.Add(isFemale);
            Controls.Add(isMale);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Day);
            Controls.Add(mnameTextBox);
            Controls.Add(fnameTextBox);
            Controls.Add(lnameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox lnameTextBox;
        private TextBox fnameTextBox;
        private TextBox mnameTextBox;
        private ComboBox Day;
        private ComboBox Month;
        private ComboBox Year;
        private RadioButton isMale;
        private RadioButton isFemale;
        private ComboBox selectProgram;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
