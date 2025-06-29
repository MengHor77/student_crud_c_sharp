using crud_project_c_sharp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace crud_project_c_sharp
{
    public partial class MainForm : Form
    {
       string constr =@"Data Source=DESKTOP-S99S529\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";
       
        public MainForm()
        {
            InitializeComponent();
            LoadStudent();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            try
            {
                string id = textBox_id.Text.Trim();
                string name = textBox_name.Text.Trim();
                string gender = comboBox_gender.Text.Trim();
                string age = textBox_age.Text.Trim() ;

                if  (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(gender) ) 
                {
                    MessageBox.Show(" pleas enter all field !");
                    return;
                }
                if ( (!int.TryParse(id, out int parsedId)) || (!int.TryParse(age, out int parsedAge)))
                {
                    MessageBox.Show(" pleas enter age or id as a number!");
                    return;
                }
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string insert = "INSERT INTO mstudent(id, name,gender, age ) VALUES (@id, @name, @gender, @age)";
                 SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);


                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("insert successfully !");
                        clearText();
                        LoadStudent();
                    }
                    else {
                        MessageBox.Show("insert faile");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }
        private void clearText()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_age.Clear();
            comboBox_gender.Items.Clear();
        }
        private void LoadStudent()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string getTex = "SELECT  id, name, gender, age FROM mstudent";
                    SqlDataAdapter sql_adapter = new SqlDataAdapter(getTex, con);
                    DataTable data_table = new DataTable();
                    sql_adapter.Fill(data_table);
                    dataGridView1.DataSource= data_table;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                string gender = dataGridView1.CurrentRow.Cells["gender"].Value.ToString();
                string age = dataGridView1.CurrentRow.Cells["age"].Value.ToString();



                Edit editform = new Edit( id, name,gender, age);
                editform.ShowDialog();

                // Optionally reload data after editing
                LoadStudent();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                string age = row.Cells["age"].Value.ToString();
                // send data to form edit 
                Edit editform = new Edit(id ,name, gender, age);

                editform.ShowDialog();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult message = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                    try
                    {
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            con.Open();
                            string delete_stu = "DELETE FROM mstudent WHERE id = @id";
                            SqlCommand cmd = new SqlCommand(delete_stu, con);
                            cmd.Parameters.AddWithValue("@id", id);
                            int row = cmd.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("Deleted successfully!");
                                LoadStudent(); // Refresh table
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
