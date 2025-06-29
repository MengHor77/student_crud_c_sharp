using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace crud_project_c_sharp.Forms
{
    public partial class Course : Form
    {
        string constr = @"Data Source=DESKTOP-S99S529\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";

        public Course()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourses();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, name FROM mstudent", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox_student_list.DataSource = dt;
                comboBox_student_list.DisplayMember = "name";
                comboBox_student_list.ValueMember = "id";
            }
        }

        private void LoadCourses()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = @"SELECT cs.id_course, cs.name_course, s.name AS student_name, cs.date
                               FROM course_student cs
                               INNER JOIN mstudent s ON cs.id = s.id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_course.DataSource = dt;
            }
        }

        private void ClearForm()
        {
            textBox_id_course.Clear();
            textBox_course_name.Clear();
            comboBox_student_list.SelectedIndex = 0;
            dateTimePicker_course.Value = DateTime.Now;
        }

        private void button_add_course_Click(object sender, EventArgs e)
        {
            try
            {
                string courseId = textBox_id_course.Text;
                string courseName = textBox_course_name.Text;
                DateTime courseDate = dateTimePicker_course.Value;
                int studentId = Convert.ToInt32(comboBox_student_list.SelectedValue);

                if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                if (!int.TryParse(courseId, out int parsedCourseId))
                {
                    MessageBox.Show("Course ID must be a number.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    string sql = "INSERT INTO course_student (id_course, name_course, date, id) VALUES (@id_course, @name_course, @date, @id)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_course", courseId);
                    cmd.Parameters.AddWithValue("@name_course", courseName);
                    cmd.Parameters.AddWithValue("@date", courseDate);
                    cmd.Parameters.AddWithValue("@id", studentId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Course added successfully!");
                    }
                }
                ClearForm();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      
        private void dataGridView_course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_course.Rows[e.RowIndex];
                textBox_id_course.Text = row.Cells["id_course"].Value.ToString();
                textBox_course_name.Text = row.Cells["name_course"].Value.ToString();
                dateTimePicker_course.Value = Convert.ToDateTime(row.Cells["date"].Value);
                comboBox_student_list.Text = row.Cells["student_name"].Value.ToString();
            }
        }

        private void button_edit_course_Click_1(object sender, EventArgs e)
        {
            if (dataGridView_course.CurrentRow != null)
            {
                int courseId = Convert.ToInt32(dataGridView_course.CurrentRow.Cells["id_course"].Value);
                string courseName = dataGridView_course.CurrentRow.Cells["name_course"].Value.ToString();
                DateTime courseDate = Convert.ToDateTime(dataGridView_course.CurrentRow.Cells["date"].Value);

                // Find student ID from the course_student table:
                int studentId = GetStudentIdByCourseId(courseId);

                EditFormCourse editFormCourse = new EditFormCourse(courseId, courseName, courseDate, studentId);

                if (editFormCourse.ShowDialog() == DialogResult.OK)
                {
                    LoadCourses(); // Refresh after editing
                }
            }
            else
            {
                MessageBox.Show("Please select a course to edit.");
            }
        }

        private int GetStudentIdByCourseId(int courseId)
        {
            int studentId = -1;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "SELECT id FROM course_student WHERE id_course = @id_course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_course", courseId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    studentId = Convert.ToInt32(result);
                }
            }
            return studentId;
        }

        private void button_delete_course_Click_1(object sender, EventArgs e)
        {
        
            if (dataGridView_course.CurrentRow != null)
            {
                DialogResult message = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_course.CurrentRow.Cells["id_course"].Value);

                    try
                    {
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            con.Open();
                            string delete_course = "DELETE FROM course_student WHERE id_course = @id_course";
                            SqlCommand cmd = new SqlCommand(delete_course, con);
                            cmd.Parameters.AddWithValue("@id_course", id);
                            int row = cmd.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("Deleted successfully!");
                                LoadCourses(); // Refresh table
                            }
                            else
                            {
                                MessageBox.Show("Delete failed.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    
    }
}
