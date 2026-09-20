namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
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
            title = new Label();
            LastNametxt = new TextBox();
            FirstNametxt = new TextBox();
            MiddleNametxt = new TextBox();
            LastName = new Label();
            FirstName = new Label();
            MiddleName = new Label();
            Gender = new Label();
            maleBtn = new RadioButton();
            femaleBtn = new RadioButton();
            birthDate = new Label();
            dayBox = new ComboBox();
            monthBox = new ComboBox();
            yearBox = new ComboBox();
            Register = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TertiaryProgram = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            BrowseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial", 19F, FontStyle.Bold);
            title.Location = new Point(140, 9);
            title.Name = "title";
            title.Size = new Size(336, 30);
            title.TabIndex = 0;
            title.Text = "Student Registration form";
            // 
            // LastNametxt
            // 
            LastNametxt.ForeColor = SystemColors.WindowText;
            LastNametxt.Location = new Point(12, 77);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(336, 23);
            LastNametxt.TabIndex = 1;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(12, 149);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(336, 23);
            FirstNametxt.TabIndex = 2;
            // 
            // MiddleNametxt
            // 
            MiddleNametxt.Location = new Point(12, 211);
            MiddleNametxt.Name = "MiddleNametxt";
            MiddleNametxt.Size = new Size(336, 23);
            MiddleNametxt.TabIndex = 3;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Arial", 12F, FontStyle.Bold);
            LastName.Location = new Point(12, 55);
            LastName.Name = "LastName";
            LastName.Size = new Size(94, 19);
            LastName.TabIndex = 4;
            LastName.Text = "Last name*";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Arial", 12F, FontStyle.Bold);
            FirstName.Location = new Point(12, 127);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(95, 19);
            FirstName.TabIndex = 5;
            FirstName.Text = "First name*";
            // 
            // MiddleName
            // 
            MiddleName.AutoSize = true;
            MiddleName.Font = new Font("Arial", 12F, FontStyle.Bold);
            MiddleName.Location = new Point(12, 189);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(111, 19);
            MiddleName.TabIndex = 6;
            MiddleName.Text = "Middle name*";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Arial", 12F, FontStyle.Bold);
            Gender.Location = new Point(12, 248);
            Gender.Name = "Gender";
            Gender.Size = new Size(71, 19);
            Gender.TabIndex = 7;
            Gender.Text = "Gender*";
            // 
            // maleBtn
            // 
            maleBtn.AutoSize = true;
            maleBtn.Location = new Point(129, 249);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(51, 19);
            maleBtn.TabIndex = 8;
            maleBtn.TabStop = true;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // femaleBtn
            // 
            femaleBtn.AutoSize = true;
            femaleBtn.Location = new Point(213, 248);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(63, 19);
            femaleBtn.TabIndex = 9;
            femaleBtn.TabStop = true;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            birthDate.Location = new Point(12, 292);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(108, 19);
            birthDate.TabIndex = 10;
            birthDate.Text = "Date of birth*";
            // 
            // dayBox
            // 
            dayBox.FormattingEnabled = true;
            dayBox.Location = new Point(12, 314);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(94, 23);
            dayBox.TabIndex = 11;
            dayBox.Text = "- Day -";
            // 
            // monthBox
            // 
            monthBox.FormattingEnabled = true;
            monthBox.Location = new Point(112, 314);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(113, 23);
            monthBox.TabIndex = 12;
            monthBox.Text = "- Month -";
            // 
            // yearBox
            // 
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(231, 314);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(121, 23);
            yearBox.TabIndex = 13;
            yearBox.Text = "- Year -";
            // 
            // Register
            // 
            Register.BackColor = Color.Crimson;
            Register.ForeColor = SystemColors.HighlightText;
            Register.Location = new Point(12, 407);
            Register.Name = "Register";
            Register.Size = new Size(213, 49);
            Register.TabIndex = 14;
            Register.Text = "Register Student";
            Register.UseVisualStyleBackColor = false;
            Register.Click += registerBtn;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(407, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(12, 356);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 16;
            label1.Text = " Program to apply*";
            // 
            // TertiaryProgram
            // 
            TertiaryProgram.FormattingEnabled = true;
            TertiaryProgram.Location = new Point(13, 378);
            TertiaryProgram.Name = "TertiaryProgram";
            TertiaryProgram.Size = new Size(339, 23);
            TertiaryProgram.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(436, 240);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(105, 27);
            BrowseBtn.TabIndex = 18;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(607, 468);
            Controls.Add(BrowseBtn);
            Controls.Add(TertiaryProgram);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Register);
            Controls.Add(yearBox);
            Controls.Add(monthBox);
            Controls.Add(dayBox);
            Controls.Add(birthDate);
            Controls.Add(femaleBtn);
            Controls.Add(maleBtn);
            Controls.Add(Gender);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(MiddleNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(LastNametxt);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStudentRegistration";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label title;
        private TextBox LastNametxt;
        private TextBox FirstNametxt;
        private TextBox MiddleNametxt;
        private Label LastName;
        private Label FirstName;
        private Label MiddleName;
        private Label Gender;
        private RadioButton maleBtn;
        private RadioButton femaleBtn;
        private Label birthDate;
        private ComboBox dayBox;
        private ComboBox monthBox;
        private ComboBox yearBox;
        private Button Register;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox TertiaryProgram;
        private OpenFileDialog openFileDialog1;
        private Button BrowseBtn;
    }
}
