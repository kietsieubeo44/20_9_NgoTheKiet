using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_9_NgoTheKiet
{
    public partial class FormBaiTap1 : Form
    {
        public FormBaiTap1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormBaiTap1_Load(object sender, EventArgs e)
        {

        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + txtYourName.Text + "\n";

            if (int.TryParse(txtYear.Text, out int yearOfBirth))
            {
                age = DateTime.Now.Year - yearOfBirth;
                s = s + "Age: " + age.ToString();
                MessageBox.Show(s);
            }
            else
            {   
                MessageBox.Show("Năm sinh không hợp lệ. Vui lòng nhập một số nguyên.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            this.Close();
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "bạn phải điền tên của mình ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Năm sinh phải là số.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        
        private void FormBaiTap1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            txtYourName.Clear();

            txtYourName.Focus();
        }
    }
}
