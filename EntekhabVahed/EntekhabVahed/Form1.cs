using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace EntekhabVahed
{
    public partial class Form1 : Form
    {
        bool isAdmin = false;
        string studentId = "";


        Dictionary<string, Student> students = new Dictionary<string, Student>();
        string filePath = @"C:\202\std.txt";


        public Form1(bool adminMode, string stdId = "")
        {
            InitializeComponent();

            isAdmin = adminMode;
            studentId = stdId;

            if (!isAdmin)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }

            this.FormClosing += (s, e) => Application.Exit();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string family = txtFamily.Text;

            List<string> selectedCourses = new List<string>();
            foreach (var item in clbCourses.CheckedItems)
            {
                selectedCourses.Add(item.ToString());
            }

            if (id == "" || name == "" || family == "" || selectedCourses.Count == 0)
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید و حداقل یک درس انتخاب کنید.");
                return;
            }

            Student std = new Student(id, name, family, selectedCourses);
            students[id] = std;

           
            SaveToFile();

            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
            ClearFields();

        }

        private void SaveToFile()
        {
            List<string> lines = new List<string>();
            foreach (var item in students.Values)
            {
                lines.Add(item.ToString());
            }
            System.IO.File.AppendAllLines(filePath, lines);
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            for (int i = 0; i < clbCourses.Items.Count; i++)
            {
                clbCourses.SetItemChecked(i, false);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("فایلی برای نمایش وجود ندارد.");
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length < 4) continue;

                string id = parts[0];
                string name = parts[1];
                string family = parts[2];
                string coursesRaw = parts[3];

                if (isAdmin || id == studentId)
                {
                    string[] courses = coursesRaw.Split('|');
                    string info = $"[{id}] {name} {family} - دروس: {string.Join("، ", courses)}";
                    lstShow.Items.Add(info);
                }
            }

            if (lstShow.Items.Count == 0)
            {
                lstShow.Items.Add(clbCourses.Text);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            string targetId = txtId.Text.Trim();
            if (string.IsNullOrEmpty(targetId))
            {
                MessageBox.Show("لطفاً شناسه را وارد کنید.");
                return;
            }

           
            if (!File.Exists(filePath))
            {
                MessageBox.Show("فایل داده پیدا نشد.");
                return;
            }

            
            var remaining = File.ReadAllLines(filePath)
                .Where(line => {
                    var parts = line.Split(',');
                    return parts.Length >= 4 && parts[0] != targetId;
                })
                .ToArray();

           
            File.WriteAllLines(filePath, remaining);

            lstShow.Items.Remove(targetId);

            
           
            clbCourses.Items.Clear();  

            MessageBox.Show("دانشجو با موفقیت حذف شد.");
        }





        private void btnEdit_Click(object sender, EventArgs e)
        {
            string targetId = txtId.Text.Trim();
            string newName = txtName.Text.Trim();
            string newFamily = txtFamily.Text.Trim();

          
            if (string.IsNullOrEmpty(targetId) ||
                string.IsNullOrEmpty(newName) ||
                string.IsNullOrEmpty(newFamily))
            {
                MessageBox.Show("لطفاً شناسه، نام و نام‌خانوادگی را وارد کنید.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("فایل داده پیدا نشد.");
                return;
            }

          
            var students = new Dictionary<string, Student>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length < 4) continue;
                var id = parts[0];
                var name = parts[1];
                var family = parts[2];
                var courses = parts[3].Split('|').ToList();
                students[id] = new Student(id, name, family, courses);
            }

            if (!students.ContainsKey(targetId))
            {
                MessageBox.Show("دانشجویی با این شناسه پیدا نشد.");
                return;
            }

           
            var selected = clbCourses.CheckedItems
                              .Cast<string>()
                              .ToList();

            
            var updatedCourses = selected.Count > 0
                ? selected
                : students[targetId].Courses;

           
            students[targetId] = new Student(targetId, newName, newFamily, updatedCourses);

            var output = students.Values
                .Select(s => $"{s.Id},{s.Name},{s.Family},{string.Join("|", s.Courses)}");
            File.WriteAllLines(filePath, output);

          
            MessageBox.Show("اطلاعات با موفقیت ویرایش شد.");
            txtId.Clear();
            txtName.Clear();
            txtFamily.Clear();

            
            clbCourses.Items.Clear();
            foreach (var course in updatedCourses)
                clbCourses.Items.Add(course);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime navid= DateTime.Now;
            tls1.Text =navid.ToString();
        }

        private void lstShow_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void tls1_Click(object sender, EventArgs e)
        {

        }
    }
}
