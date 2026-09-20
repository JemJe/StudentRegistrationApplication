namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.load_StudentRegistrationForm);
        }

        private void load_StudentRegistrationForm(object sender, EventArgs e)
        {
            dayBox.Items.Clear();
            dayBox.Items.Add("- Day -");
            for (int day = 1; day <= 31; day++)
            {
                dayBox.Items.Add(day);
            }
            dayBox.SelectedIndex = 0;

            monthBox.Items.Clear();
            monthBox.Items.Add("- Month -");
            for (int month = 1; month <= 12; month++)
            {
                monthBox.Items.Add(month);
            }
            monthBox.SelectedIndex = 0;

            yearBox.Items.Clear();
            yearBox.Items.Add("- Year -");
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                yearBox.Items.Add(year);
            }
            yearBox.SelectedIndex = 0;

            if (TertiaryProgram != null)
            {
                TertiaryProgram.Items.Add("BS in Computer Science");
                TertiaryProgram.Items.Add("BS in Information Technology");
                TertiaryProgram.Items.Add("BS in Business Administration");
                TertiaryProgram.Items.Add("BS in Psychology");
                TertiaryProgram.Items.Add("BS in Mathematics");
                TertiaryProgram.Items.Add("BS in Biology");
                TertiaryProgram.Items.Add("BS in Chemistry");
            }
        }

        private void registerBtn(object sender, EventArgs e)
        {
            string lastName = LastNametxt.Text;
            string firstName = FirstNametxt.Text;
            string middleName = MiddleNametxt.Text;


            string gender = "";
            if (maleBtn.Checked)
            {
                gender = "Male";
            }
            else if (femaleBtn.Checked)
            {
                gender = "Female";
            }

            string program = TertiaryProgram.SelectedItem != null ? TertiaryProgram.SelectedItem.ToString() : "";
            string day = dayBox.SelectedItem != null ? dayBox.SelectedItem.ToString() : "";
            string month = monthBox.SelectedItem != null ? monthBox.SelectedItem.ToString() : "";
            string year = yearBox.SelectedItem != null ? yearBox.SelectedItem.ToString() : "";
            string dateOfBirth = $"{day}/{month}/{year}";

            StudentInfo(lastName, firstName, program);
            StudentInfo(lastName, firstName, middleName, program);
            StudentInfo(lastName, firstName, middleName, gender, dateOfBirth, program);

        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        public void StudentInfo(string lastName, string firstName, string program)
        {
            MessageBox.Show($"Student name: {firstName}" +
                                         $" {lastName}" +
                                         $"\nProgram: {program}", "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void StudentInfo(string lastName, string firstName, string middleName, string program)
        {
            MessageBox.Show($"Student name: {firstName} " +
                                          $"{middleName}. " +
                                          $"{lastName}" +
                                          $"\nProgram: {program}" +
                                          $"", "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void StudentInfo(string lastName, string firstName, string middleName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show($"Student name: {firstName} " +
                                          $"{middleName}. " +
                                          $"{lastName}" +
                                          $"\nGender: {gender}" +
                                          $"\nDate of Birth: {dateOfBirth}" +
                                          $"\nProgram: {program} ", 
                                          "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
