using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class StudentInformationControl : UserControl
    {
        List<Student> students;
        public StudentInformationControl()
        {
            InitializeComponent();
            students = new List<Student>();
            tbMSSV.Text = GenerateMSSV();
        }
        private string GenerateMSSV()
        {
            return "215" + (students.Count+1).ToString().PadLeft(4, '0');
        }
        private void TbFullname_TextChanged(object sender, EventArgs e)
        {
            string[] names = tbFullname.Text.Split(' ');
            
            tbTen.Text = UpperFirstWord(names[names.Length - 1]);
           
            string TenLot = "";
            if (names.Length > 2 || tbFullname.Text != "") //check tên với 2 chữ - Nguyễn Văn
            {
                for (int i = 0; i < names.Length - 1; i++)
                {
                    TenLot += UpperFirstWord(names[i]) + " ";
                }
                tbHoLot.Text = TenLot;
            }
            for (int i = 0; i < names.Length; i++)
            {
                
                if (tbFullname.Text.ToLower().Contains("thị") || tbFullname.Text.ToLower().Contains("thi"))
                {
                    cbGioiTinh.Text = (string)cbGioiTinh.Items[1];
                }
                else
                {
                    if (tbFullname.Text.ToLower().Contains("văn") || tbFullname.Text.ToLower().Contains("van"))
                    {
                        cbGioiTinh.Text = (string)cbGioiTinh.Items[0];
                    }
                    else
                    {
                        cbGioiTinh.Text = (string)cbGioiTinh.Items[2];
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            students.Add(new Student {
                Mssv = tbMSSV.Text,
                Ten = tbTen.Text,
                HoLot = tbHoLot.Text,
                GioiTinh = cbGioiTinh.Text
            });
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            tbMSSV.Text = GenerateMSSV();
            tbFullname.Text = "";
            tbHoLot.Text = "";
            tbTen.Text = "";
            cbGioiTinh.Text = cbGioiTinh.Items[0].ToString();
        }
        private string UpperFirstWord(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string mess = string.Empty;
            string mess = "";
            foreach (Student student in students)
            {
                mess += student.ToString();
                
            }
            MessageBox.Show(mess, "Student Details");
        }
    }
}
