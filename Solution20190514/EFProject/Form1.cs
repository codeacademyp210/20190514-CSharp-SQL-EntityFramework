using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Models;

namespace EFProject
{
    public partial class Form1 : Form
    {
        private readonly AcademyEntities academy;


        public Form1()
        {
            InitializeComponent();
            academy = new AcademyEntities();
        }

        private void btnFillStudents_Click(object sender, EventArgs e)
        {
            //cmbStudent.DataSource = academy.Students.Where(s => s.Gender==false).Select(s => s.Name + " " + s.Surname).ToList();
            List<Group> myGroups = academy.Groups.Where(g => g.Id == 1).ToList();
            foreach (var i in myGroups)
            {
                cmbStudent.Items.Add(i.Mentor.Name);
            }
        }

        private void Test()
        {
            List<string> names = new List<string>();

        }
    }
}
