namespace crud_project_c_sharp.Forms
{
    partial class Course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id_label_course = new System.Windows.Forms.Label();
            this.textBox_id_course = new System.Windows.Forms.TextBox();
            this.label_course_name = new System.Windows.Forms.Label();
            this.textBox_course_name = new System.Windows.Forms.TextBox();
            this.label_student_course = new System.Windows.Forms.Label();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.button_add_course = new System.Windows.Forms.Button();
            this.button_edit_course = new System.Windows.Forms.Button();
            this.button_delete_course = new System.Windows.Forms.Button();
            this.comboBox_student_list = new System.Windows.Forms.ComboBox();
            this.label_dateTime_course = new System.Windows.Forms.Label();
            this.dateTimePicker_course = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id_label_course
            // 
            this.label_id_label_course.AutoSize = true;
            this.label_id_label_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_label_course.Location = new System.Drawing.Point(99, 83);
            this.label_id_label_course.Name = "label_id_label_course";
            this.label_id_label_course.Size = new System.Drawing.Size(91, 22);
            this.label_id_label_course.TabIndex = 0;
            this.label_id_label_course.Text = "ID_course";
            // 
            // textBox_id_course
            // 
            this.textBox_id_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id_course.Location = new System.Drawing.Point(228, 77);
            this.textBox_id_course.Name = "textBox_id_course";
            this.textBox_id_course.Size = new System.Drawing.Size(162, 28);
            this.textBox_id_course.TabIndex = 1;
            // 
            // label_course_name
            // 
            this.label_course_name.AutoSize = true;
            this.label_course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course_name.Location = new System.Drawing.Point(99, 132);
            this.label_course_name.Name = "label_course_name";
            this.label_course_name.Size = new System.Drawing.Size(122, 22);
            this.label_course_name.TabIndex = 2;
            this.label_course_name.Text = "Course_name";
            // 
            // textBox_course_name
            // 
            this.textBox_course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_course_name.Location = new System.Drawing.Point(228, 132);
            this.textBox_course_name.Name = "textBox_course_name";
            this.textBox_course_name.Size = new System.Drawing.Size(162, 28);
            this.textBox_course_name.TabIndex = 3;
            // 
            // label_student_course
            // 
            this.label_student_course.AutoSize = true;
            this.label_student_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_course.Location = new System.Drawing.Point(99, 182);
            this.label_student_course.Name = "label_student_course";
            this.label_student_course.Size = new System.Drawing.Size(126, 22);
            this.label_student_course.TabIndex = 4;
            this.label_student_course.Text = "Student_name";
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_course.Location = new System.Drawing.Point(24, 338);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowHeadersWidth = 51;
            this.dataGridView_course.RowTemplate.Height = 24;
            this.dataGridView_course.Size = new System.Drawing.Size(721, 220);
            this.dataGridView_course.TabIndex = 6;
            // 
            // button_add_course
            // 
            this.button_add_course.Location = new System.Drawing.Point(83, 286);
            this.button_add_course.Name = "button_add_course";
            this.button_add_course.Size = new System.Drawing.Size(142, 23);
            this.button_add_course.TabIndex = 7;
            this.button_add_course.Text = "Add new course";
            this.button_add_course.UseVisualStyleBackColor = true;
            this.button_add_course.Click += new System.EventHandler(this.button_add_course_Click);
            // 
            // button_edit_course
            // 
            this.button_edit_course.Location = new System.Drawing.Point(257, 286);
            this.button_edit_course.Name = "button_edit_course";
            this.button_edit_course.Size = new System.Drawing.Size(133, 23);
            this.button_edit_course.TabIndex = 8;
            this.button_edit_course.Text = "Edit_course";
            this.button_edit_course.UseVisualStyleBackColor = true;
            this.button_edit_course.Click += new System.EventHandler(this.button_edit_course_Click_1);
            // 
            // button_delete_course
            // 
            this.button_delete_course.Location = new System.Drawing.Point(415, 286);
            this.button_delete_course.Name = "button_delete_course";
            this.button_delete_course.Size = new System.Drawing.Size(133, 23);
            this.button_delete_course.TabIndex = 9;
            this.button_delete_course.Text = "Delete_course";
            this.button_delete_course.UseVisualStyleBackColor = true;
            this.button_delete_course.Click += new System.EventHandler(this.button_delete_course_Click_1);
            // 
            // comboBox_student_list
            // 
            this.comboBox_student_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_student_list.FormattingEnabled = true;
            this.comboBox_student_list.Location = new System.Drawing.Point(228, 184);
            this.comboBox_student_list.Name = "comboBox_student_list";
            this.comboBox_student_list.Size = new System.Drawing.Size(162, 30);
            this.comboBox_student_list.TabIndex = 10;
            // 
            // label_dateTime_course
            // 
            this.label_dateTime_course.AutoSize = true;
            this.label_dateTime_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateTime_course.Location = new System.Drawing.Point(99, 225);
            this.label_dateTime_course.Name = "label_dateTime_course";
            this.label_dateTime_course.Size = new System.Drawing.Size(91, 22);
            this.label_dateTime_course.TabIndex = 11;
            this.label_dateTime_course.Text = "Date_time";
            // 
            // dateTimePicker_course
            // 
            this.dateTimePicker_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_course.Location = new System.Drawing.Point(228, 225);
            this.dateTimePicker_course.Name = "dateTimePicker_course";
            this.dateTimePicker_course.Size = new System.Drawing.Size(302, 27);
            this.dateTimePicker_course.TabIndex = 12;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 561);
            this.Controls.Add(this.dateTimePicker_course);
            this.Controls.Add(this.label_dateTime_course);
            this.Controls.Add(this.comboBox_student_list);
            this.Controls.Add(this.button_delete_course);
            this.Controls.Add(this.button_edit_course);
            this.Controls.Add(this.button_add_course);
            this.Controls.Add(this.dataGridView_course);
            this.Controls.Add(this.label_student_course);
            this.Controls.Add(this.textBox_course_name);
            this.Controls.Add(this.label_course_name);
            this.Controls.Add(this.textBox_id_course);
            this.Controls.Add(this.label_id_label_course);
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id_label_course;
        private System.Windows.Forms.TextBox textBox_id_course;
        private System.Windows.Forms.Label label_course_name;
        private System.Windows.Forms.TextBox textBox_course_name;
        private System.Windows.Forms.Label label_student_course;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.Button button_add_course;
        private System.Windows.Forms.Button button_edit_course;
        private System.Windows.Forms.Button button_delete_course;
        private System.Windows.Forms.ComboBox comboBox_student_list;
        private System.Windows.Forms.Label label_dateTime_course;
        private System.Windows.Forms.DateTimePicker dateTimePicker_course;
    }
}