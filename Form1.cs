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
using System.Collections;

namespace JSONParser
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentName.Text = "";
            cbDegree.Text = "";
            tbHobbies.Text = "";
            richTextBox1.Text = "";
        }

        private void btnRawJson_click(object sender, EventArgs e)
        {
            string[] array = tbHobbies.Text.Split(',');
            Student student = new Student()
            {
                Id = 1,
                Name = tbStudentName.Text,
                Degree = cbDegree.Text,
                Hobbies = new List<string>(array)
            };
            string strResultJson = JsonConvert.SerializeObject(student);
            richTextBox1.Text = "";
            richTextBox1.Text = strResultJson;
            Console.WriteLine("Serialized!");
        }

        private void btnParse_click(object sender, EventArgs e)
        {
            string[] array = tbHobbies.Text.Split(',');
            Student student = new Student()
            {
                Id = 1,
                Name = tbStudentName.Text,
                Degree = cbDegree.Text,
                Hobbies = new List<string>(array)
            };
            string strResultJson = JsonConvert.SerializeObject(student);
            Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            richTextBox1.Text = "";
            richTextBox1.Text = resultStudent.ToString();
            Console.WriteLine("Deserialized!");
        }

        private void btnDownload_click(object sender, EventArgs e)
        {
            var results = richTextBox1.Text;
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Create an output first", "Empty Field",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "|*.json";
                sfd.FileName = "student";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = sfd.FileName;
                    BinaryWriter bw = new BinaryWriter(File.Create(path));
                    bw.Write(System.Text.Encoding.UTF8.GetBytes(results));
                    bw.Dispose();
                }
            }
        }
    }
}
