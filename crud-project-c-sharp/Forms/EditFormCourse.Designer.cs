namespace crud_project_c_sharp.Forms
{
    partial class EditFormCourse
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
            this.label_course_name = new System.Windows.Forms.Label();
            this.textBox_course_name_edit = new System.Windows.Forms.TextBox();
            this.label_student_name = new System.Windows.Forms.Label();
            this.comboBox_student_incourse = new System.Windows.Forms.ComboBox();
            this.label_date_time_in_edite = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_save_in_edit = new System.Windows.Forms.Button();
            this.button_cancel_in_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_course_name
            // 
            this.label_course_name.AutoSize = true;
            this.label_course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course_name.Location = new System.Drawing.Point(51, 62);
            this.label_course_name.Name = "label_course_name";
            this.label_course_name.Size = new System.Drawing.Size(118, 22);
            this.label_course_name.TabIndex = 0;
            this.label_course_name.Text = "course_name";
            // 
            // textBox_course_name_edit
            // 
            this.textBox_course_name_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_course_name_edit.Location = new System.Drawing.Point(194, 62);
            this.textBox_course_name_edit.Name = "textBox_course_name_edit";
            this.textBox_course_name_edit.Size = new System.Drawing.Size(247, 28);
            this.textBox_course_name_edit.TabIndex = 1;
            // 
            // label_student_name
            // 
            this.label_student_name.AutoSize = true;
            this.label_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_name.Location = new System.Drawing.Point(51, 124);
            this.label_student_name.Name = "label_student_name";
            this.label_student_name.Size = new System.Drawing.Size(126, 22);
            this.label_student_name.TabIndex = 2;
            this.label_student_name.Text = "Student_name";
            // 
            // comboBox_student_incourse
            // 
            this.comboBox_student_incourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_student_incourse.FormattingEnabled = true;
            this.comboBox_student_incourse.Location = new System.Drawing.Point(194, 121);
            this.comboBox_student_incourse.Name = "comboBox_student_incourse";
            this.comboBox_student_incourse.Size = new System.Drawing.Size(247, 30);
            this.comboBox_student_incourse.TabIndex = 3;
            // 
            // label_date_time_in_edite
            // 
            this.label_date_time_in_edite.AutoSize = true;
            this.label_date_time_in_edite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_time_in_edite.Location = new System.Drawing.Point(59, 191);
            this.label_date_time_in_edite.Name = "label_date_time_in_edite";
            this.label_date_time_in_edite.Size = new System.Drawing.Size(91, 22);
            this.label_date_time_in_edite.TabIndex = 4;
            this.label_date_time_in_edite.Text = "Date_time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 28);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button_save_in_edit
            // 
            this.button_save_in_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_in_edit.Location = new System.Drawing.Point(194, 263);
            this.button_save_in_edit.Name = "button_save_in_edit";
            this.button_save_in_edit.Size = new System.Drawing.Size(75, 23);
            this.button_save_in_edit.TabIndex = 6;
            this.button_save_in_edit.Text = "Save";
            this.button_save_in_edit.UseVisualStyleBackColor = true;
            this.button_save_in_edit.Click += new System.EventHandler(this.button_save_in_edit_Click_1);
            // 
            // button_cancel_in_edit
            // 
            this.button_cancel_in_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel_in_edit.Location = new System.Drawing.Point(366, 263);
            this.button_cancel_in_edit.Name = "button_cancel_in_edit";
            this.button_cancel_in_edit.Size = new System.Drawing.Size(75, 23);
            this.button_cancel_in_edit.TabIndex = 7;
            this.button_cancel_in_edit.Text = "Cancel";
            this.button_cancel_in_edit.UseVisualStyleBackColor = true;
            // 
            // EditFormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 328);
            this.Controls.Add(this.button_cancel_in_edit);
            this.Controls.Add(this.button_save_in_edit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_date_time_in_edite);
            this.Controls.Add(this.comboBox_student_incourse);
            this.Controls.Add(this.label_student_name);
            this.Controls.Add(this.textBox_course_name_edit);
            this.Controls.Add(this.label_course_name);
            this.Name = "EditFormCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFormCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_course_name;
        private System.Windows.Forms.TextBox textBox_course_name_edit;
        private System.Windows.Forms.Label label_student_name;
        private System.Windows.Forms.ComboBox comboBox_student_incourse;
        private System.Windows.Forms.Label label_date_time_in_edite;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_save_in_edit;
        private System.Windows.Forms.Button button_cancel_in_edit;
    }
}