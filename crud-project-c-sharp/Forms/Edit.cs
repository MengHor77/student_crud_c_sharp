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

        public Edit( int id , string name )
        {
            InitializeComponent();
            textBox_id.Text = id.ToString();
            textBox_name.Text = name;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_id.Text);
                string name = textBox_name.Text;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string insert = "INSERT INTO mstudent(id, name) VALUES (@id, @name)";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("insert successfully !");
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("insert faile");
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
