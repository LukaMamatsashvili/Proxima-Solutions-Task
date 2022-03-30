namespace CodingTask
{
    partial class Form1
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
            this.textBox_Pupil = new System.Windows.Forms.TextBox();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.textBox_Teacher = new System.Windows.Forms.TextBox();
            this.btn_AddTeacher = new System.Windows.Forms.Button();
            this.btn_AddPupil = new System.Windows.Forms.Button();
            this.btn_AddSubject = new System.Windows.Forms.Button();
            this.btn_DisplayPupils = new System.Windows.Forms.Button();
            this.btn_DisplayTeachers = new System.Windows.Forms.Button();
            this.lbl_Pupil = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_Teacher = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Pupil
            // 
            this.textBox_Pupil.Location = new System.Drawing.Point(398, 648);
            this.textBox_Pupil.Name = "textBox_Pupil";
            this.textBox_Pupil.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pupil.TabIndex = 0;
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(246, 648);
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(100, 20);
            this.textBox_Subject.TabIndex = 0;
            // 
            // textBox_Teacher
            // 
            this.textBox_Teacher.Location = new System.Drawing.Point(79, 648);
            this.textBox_Teacher.Name = "textBox_Teacher";
            this.textBox_Teacher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Teacher.TabIndex = 0;
            // 
            // btn_AddTeacher
            // 
            this.btn_AddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTeacher.Location = new System.Drawing.Point(559, 646);
            this.btn_AddTeacher.Name = "btn_AddTeacher";
            this.btn_AddTeacher.Size = new System.Drawing.Size(122, 23);
            this.btn_AddTeacher.TabIndex = 1;
            this.btn_AddTeacher.Text = "Add Teacher";
            this.btn_AddTeacher.UseVisualStyleBackColor = true;
            this.btn_AddTeacher.Click += new System.EventHandler(this.btn_AddTeacher_Click);
            // 
            // btn_AddPupil
            // 
            this.btn_AddPupil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPupil.Location = new System.Drawing.Point(815, 646);
            this.btn_AddPupil.Name = "btn_AddPupil";
            this.btn_AddPupil.Size = new System.Drawing.Size(122, 23);
            this.btn_AddPupil.TabIndex = 1;
            this.btn_AddPupil.Text = "Add Pupil";
            this.btn_AddPupil.UseVisualStyleBackColor = true;
            this.btn_AddPupil.Click += new System.EventHandler(this.btn_AddPupil_Click);
            // 
            // btn_AddSubject
            // 
            this.btn_AddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSubject.Location = new System.Drawing.Point(687, 646);
            this.btn_AddSubject.Name = "btn_AddSubject";
            this.btn_AddSubject.Size = new System.Drawing.Size(122, 23);
            this.btn_AddSubject.TabIndex = 1;
            this.btn_AddSubject.Text = "Add Subject";
            this.btn_AddSubject.UseVisualStyleBackColor = true;
            this.btn_AddSubject.Click += new System.EventHandler(this.btn_AddSubject_Click);
            // 
            // btn_DisplayPupils
            // 
            this.btn_DisplayPupils.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplayPupils.Location = new System.Drawing.Point(943, 646);
            this.btn_DisplayPupils.Name = "btn_DisplayPupils";
            this.btn_DisplayPupils.Size = new System.Drawing.Size(122, 23);
            this.btn_DisplayPupils.TabIndex = 1;
            this.btn_DisplayPupils.Text = "Display Pupils";
            this.btn_DisplayPupils.UseVisualStyleBackColor = true;
            this.btn_DisplayPupils.Click += new System.EventHandler(this.btn_DisplayPupils_Click);
            // 
            // btn_DisplayTeachers
            // 
            this.btn_DisplayTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplayTeachers.Location = new System.Drawing.Point(1071, 646);
            this.btn_DisplayTeachers.Name = "btn_DisplayTeachers";
            this.btn_DisplayTeachers.Size = new System.Drawing.Size(130, 23);
            this.btn_DisplayTeachers.TabIndex = 1;
            this.btn_DisplayTeachers.Text = "Display Teachers";
            this.btn_DisplayTeachers.UseVisualStyleBackColor = true;
            this.btn_DisplayTeachers.Click += new System.EventHandler(this.btn_DisplayTeachers_Click);
            // 
            // lbl_Pupil
            // 
            this.lbl_Pupil.AutoSize = true;
            this.lbl_Pupil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pupil.Location = new System.Drawing.Point(352, 649);
            this.lbl_Pupil.Name = "lbl_Pupil";
            this.lbl_Pupil.Size = new System.Drawing.Size(40, 16);
            this.lbl_Pupil.TabIndex = 2;
            this.lbl_Pupil.Text = "Pupil:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(185, 649);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(55, 16);
            this.lbl_Subject.TabIndex = 2;
            this.lbl_Subject.Text = "Subject:";
            // 
            // lbl_Teacher
            // 
            this.lbl_Teacher.AutoSize = true;
            this.lbl_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teacher.Location = new System.Drawing.Point(12, 649);
            this.lbl_Teacher.Name = "lbl_Teacher";
            this.lbl_Teacher.Size = new System.Drawing.Size(61, 16);
            this.lbl_Teacher.TabIndex = 2;
            this.lbl_Teacher.Text = "Teacher:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(12, 9);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(172, 46);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Results:";
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Display.Location = new System.Drawing.Point(15, 82);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(271, 25);
            this.lbl_Display.TabIndex = 5;
            this.lbl_Display.Text = "Results will be displayed here ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 681);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Teacher);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Pupil);
            this.Controls.Add(this.btn_DisplayTeachers);
            this.Controls.Add(this.btn_DisplayPupils);
            this.Controls.Add(this.btn_AddSubject);
            this.Controls.Add(this.btn_AddPupil);
            this.Controls.Add(this.btn_AddTeacher);
            this.Controls.Add(this.textBox_Teacher);
            this.Controls.Add(this.textBox_Subject);
            this.Controls.Add(this.textBox_Pupil);
            this.Name = "Form1";
            this.Text = "Coding Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Pupil;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.TextBox textBox_Teacher;
        private System.Windows.Forms.Button btn_AddTeacher;
        private System.Windows.Forms.Button btn_AddPupil;
        private System.Windows.Forms.Button btn_AddSubject;
        private System.Windows.Forms.Button btn_DisplayPupils;
        private System.Windows.Forms.Button btn_DisplayTeachers;
        private System.Windows.Forms.Label lbl_Pupil;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Teacher;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_Display;
    }
}

