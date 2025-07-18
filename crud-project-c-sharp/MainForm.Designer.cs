﻿namespace crud_project_c_sharp
{
    partial class MainForm
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_list_student = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_age = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_course = new System.Windows.Forms.Label();
            this.label_enroll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(181, 50);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 22);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(163, 107);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "name";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(237, 45);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(196, 30);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(237, 104);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(196, 30);
            this.textBox_name.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(156, 288);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 29);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(444, 288);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(94, 29);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(303, 288);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(94, 29);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 231);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_list_student
            // 
            this.label_list_student.AutoSize = true;
            this.label_list_student.BackColor = System.Drawing.Color.Gold;
            this.label_list_student.Location = new System.Drawing.Point(132, 341);
            this.label_list_student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_list_student.Name = "label_list_student";
            this.label_list_student.Size = new System.Drawing.Size(97, 20);
            this.label_list_student.TabIndex = 8;
            this.label_list_student.Text = "student List";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(151, 162);
            this.label_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(78, 25);
            this.label_gender.TabIndex = 9;
            this.label_gender.Text = "gender ";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other "});
            this.comboBox_gender.Location = new System.Drawing.Point(237, 159);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(196, 28);
            this.comboBox_gender.TabIndex = 10;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(163, 221);
            this.label_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(45, 25);
            this.label_age.TabIndex = 11;
            this.label_age.Text = "age";
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(237, 216);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(196, 30);
            this.textBox_age.TabIndex = 12;
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.BackColor = System.Drawing.Color.Yellow;
            this.label_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course.Location = new System.Drawing.Point(640, 35);
            this.label_course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(68, 22);
            this.label_course.TabIndex = 13;
            this.label_course.Text = "Course";
            this.label_course.Click += new System.EventHandler(this.label_course_Click);
            // 
            // label_enroll
            // 
            this.label_enroll.AutoSize = true;
            this.label_enroll.BackColor = System.Drawing.Color.Yellow;
            this.label_enroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enroll.Location = new System.Drawing.Point(648, 125);
            this.label_enroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_enroll.Name = "label_enroll";
            this.label_enroll.Size = new System.Drawing.Size(56, 22);
            this.label_enroll.TabIndex = 14;
            this.label_enroll.Text = "Enroll";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 627);
            this.Controls.Add(this.label_enroll);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_list_student);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_list_student;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Label label_enroll;
    }
}

