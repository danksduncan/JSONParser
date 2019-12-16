using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace JSONParser
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] array = tbHobbies.Text.Split(',');
            Student student = new Student()
            {
                Id = 1,
                Name = tbStudentName.Text,
                Degree = tbDegree.Text,
                Hobbies = new List<string>(array)
            };
            string strResultJson = JsonConvert.SerializeObject(student);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("Student Information Stored!");
            MessageBox.Show("File Created!");
        }
    }
}
