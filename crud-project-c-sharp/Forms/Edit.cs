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

namespace crud_project_c_sharp.Forms
{
    public partial class Edit : Form
    {
        string constr = @"Data Source=DESKTOP-S99S529\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";
        int  id;
        public Edit( int   id ,string name, string gender, string age )
        {
            InitializeComponent();
        
            textBox_name.Text = name;
            comboBox_gender.Text = gender;
            textBox_age.Text = age;
            this.id = id;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox_name.Text;
                string gender = comboBox_gender.Text;
                string age = textBox_age.Text;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string Update = "UPDATE  mstudent SET name =@name, gender= @gender, age= @age WHERE id =@id";
                    SqlCommand cmd = new SqlCommand(Update, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@id", id);



                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Update  successfully !");
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
