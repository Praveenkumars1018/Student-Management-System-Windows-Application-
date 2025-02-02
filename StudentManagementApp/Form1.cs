using System;
using System.IO;
using System.Windows.Forms;
using StudentManager;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        private IStudentManager studentManager;

        public Form1()
        {
            InitializeComponent();
            studentManager = new StudentManager.StudentManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add course names to the ComboBox
            cmbUpgradeCourse.Items.AddRange(Enum.GetNames(typeof(Courses)));
        }

        // Enrolling Student (Button)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtStudentID.Text);
                string studentName = txtStudentName.Text;
                int studentAge = int.Parse(txtStudentAge.Text);

                studentManager.EnrollStudent(studentId, studentName, studentAge);
                MessageBox.Show("Student data was added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Delete Student Button
        private void btndeleteid_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtdeleteid.Text);
                studentManager.DeleteStudent(studentId);
                MessageBox.Show("The student data deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Find Average Button
        private void btnFindAverage_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtAverageStudentID.Text);
                var student = studentManager.FindStudentById(studentId);

                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                double average = student.GetAverageGrade();
                MessageBox.Show($"Average grade for student {studentId}: {average}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Check Pass/Fail Button
        private void btnCheckPassFail_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtPassFailStudentID.Text);
                var student = studentManager.FindStudentById(studentId);

                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                bool passed = student.HasPassed();
                MessageBox.Show($"Student {studentId} has {(passed ? "passed" : "failed")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Save Data Button
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "studentsData.json";
                studentManager.SaveData(filePath);
                string savedData = File.ReadAllText(filePath);

                MessageBox.Show($"Data saved successfully!\n\n{savedData}", "Saved Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Load Data Button
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "studentsData.json";
                studentManager.LoadData(filePath);
                MessageBox.Show("Data loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Update Grade Button
        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtUpgradeStudentID.Text);

                if (cmbUpgradeCourse.SelectedItem == null)
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                string course = cmbUpgradeCourse.SelectedItem.ToString();
                int grade = int.Parse(txtGrade.Text);

                var student = studentManager.FindStudentById(studentId);
                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                student.UpdateGrade(course, grade);
                MessageBox.Show("Grade updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for ComboBox Selection Change (Course Update)
        private void cmbUpgradeCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpgradeCourse.SelectedItem != null)
            {
                string selectedCourse = cmbUpgradeCourse.SelectedItem.ToString();
                MessageBox.Show($"Selected Course: {selectedCourse}");
            }
        }

        // Placeholder event handlers for labels and textboxes (optional)
        private void lblStudentID_Click(object sender, EventArgs e) { }
        private void txtStudentID_TextChanged(object sender, EventArgs e) { }
        private void lblStudentName_Click(object sender, EventArgs e) { }
        private void txtStudentName_TextChanged(object sender, EventArgs e) { }
        private void lblStudentAge_Click(object sender, EventArgs e) { }
        private void txtStudentAge_TextChanged(object sender, EventArgs e) { }
        private void lblGrade_Click(object sender, EventArgs e) { }
        private void txtGrade_TextChanged(object sender, EventArgs e) { }
        private void lblUpgradeStudentID_Click(object sender, EventArgs e) { }
        private void txtUpgradeStudentID_TextChanged(object sender, EventArgs e) { }
        private void lblUpgradeCourse_Click(object sender, EventArgs e) { }
        private void txtAverageStudentID_TextChanged(object sender, EventArgs e) { }
        private void txtPassFailStudentID_TextChanged(object sender, EventArgs e) { }

        // Event handlers for labels when clicked (no functionality)
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void idlabel_Click(object sender, EventArgs e) { }

        private void txtdeleteid_TextChanged(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRetrieveGrades_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(TxtRetrivebtn.Text);
                var student = studentManager.FindStudentById(studentId);

                if (student == null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                string gradesInfo = student.RetrieveGrades();
                MessageBox.Show(gradesInfo, "Student Grades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}