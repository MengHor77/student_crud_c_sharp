using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace crud_project_c_sharp.Forms
{
    public partial class EditFormCourse : Form
    {
        string constr = @"Data Source=DESKTOP-S99S529\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";

        private int courseId;
        private int studentId;

        public EditFormCourse(int courseId, string courseName, DateTime courseDate, int studentId)
        {
            InitializeComponent();

            this.courseId = courseId;
            this.studentId = studentId;

            // Set initial values to controls
            textBox_course_name_edit.Text = courseName;
            dateTimePicker1.Value = courseDate;

            LoadStudents();

            // Select the student in combo box by ID
            comboBox_student_incourse.SelectedValue = studentId;

            // Hook up Cancel button event
            button_cancel_in_edit.Click += (s, e) => this.Close();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, name FROM mstudent", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                comboBox_student_incourse.DataSource = dt;
                comboBox_student_incourse.DisplayMember = "name";
                comboBox_student_incourse.ValueMember = "id";
            }
        }

    

        private void button_save_in_edit_Click_1(object sender, EventArgs e)
        {
   
            try
            {
                string courseName = textBox_course_name_edit.Text.Trim();
                DateTime courseDate = dateTimePicker1.Value;
                int selectedStudentId = Convert.ToInt32(comboBox_student_incourse.SelectedValue);

                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Course name cannot be empty.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    string sql = "UPDATE course_student SET name_course = @name_course, date = @date, id = @studentId WHERE id_course = @id_course";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name_course", courseName);
                    cmd.Parameters.AddWithValue("@date", courseDate);
                    cmd.Parameters.AddWithValue("@studentId", selectedStudentId);
                    cmd.Parameters.AddWithValue("@id_course", courseId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Course updated successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message);
            }
        }
    }
    
}
