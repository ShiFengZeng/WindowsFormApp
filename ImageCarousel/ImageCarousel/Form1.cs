using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCarousel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png;, *.bmp;";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string strFilename in openFileDialog.FileNames)
                {
                    pictureList.Items.Add(strFilename);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (pictureList.SelectedIndex != -1)
                pictureList.Items.RemoveAt(pictureList.SelectedIndex);
        }

        private void setButton_Click(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            timer1.Interval = int.Parse(intervalText.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureList.Items.Count != 0)
            {
                pictureList.SelectedIndex = (pictureList.SelectedIndex + 1) % pictureList.Items.Count;
                pictureBox.ImageLocation = pictureList.Items[pictureList.SelectedIndex].ToString();
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pictureList.Visible)
            {
                pictureList.Visible = false;
                addButton.Visible = false;
                removeButton.Visible = false;
                setButton.Visible = false;
                intervalText.Visible = false;
            }
            else
            {
                pictureList.Visible = true;
                addButton.Visible = true;
                removeButton.Visible = true;
                setButton.Visible = true;
                intervalText.Visible = true;
            }
        }

        private void intervalText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            }
        }
    }
}
