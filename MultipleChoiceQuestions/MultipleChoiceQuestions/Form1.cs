using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceQuestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
                MessageBox.Show("複選題正確！", "正確", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("複選題錯誤！正解為22和48", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if(radioButton1.Checked)
                MessageBox.Show("單選題題正確！", "正確", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("單選題錯誤！正解為23", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
