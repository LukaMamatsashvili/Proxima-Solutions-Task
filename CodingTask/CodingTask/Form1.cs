using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        School S = new School();
        HashSet<string> Pupils = new HashSet<string>();
        HashSet<string> Teachers = new HashSet<string>();

        private void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            S.addTeacher(textBox_Teacher.Text);
            if(textBox_Teacher.Text != "") MessageBox.Show("\tYou added teacher!\t");
        }

        private void btn_AddSubject_Click(object sender, EventArgs e)
        {
            S.addSubject(textBox_Teacher.Text, textBox_Subject.Text);
            if (textBox_Subject.Text != "") MessageBox.Show("\tYou added subject!\t");
        }

        private void btn_AddPupil_Click(object sender, EventArgs e)
        {
            S.addPupil(textBox_Pupil.Text, textBox_Subject.Text);
            if (textBox_Pupil.Text != "") MessageBox.Show("\tYou added pupil!\t");
        }

        private void btn_DisplayPupils_Click(object sender, EventArgs e)
        {
            Pupils.Clear();
            lbl_Display.Text = "";
            Pupils = (HashSet<string>)S.getPupils(textBox_Teacher.Text);
            lbl_Display.Text = $"{textBox_Teacher.Text}'s pupils: ";
            foreach(var item in Pupils) lbl_Display.Text += item + "; ";
        }

        private void btn_DisplayTeachers_Click(object sender, EventArgs e)
        {
            Teachers.Clear();
            lbl_Display.Text = "";
            Teachers = (HashSet<string>)S.getTeachers(textBox_Pupil.Text);
            lbl_Display.Text = $"{textBox_Pupil.Text}'s teachers: ";
            foreach(var item in Teachers) lbl_Display.Text += item + "; ";
        }
    }
}