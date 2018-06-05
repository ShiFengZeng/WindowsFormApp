using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            this.Text = "";
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FileName = "";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openDialog.FileName, RichTextBoxStreamType.PlainText);
                saveDialog.FileName = Path.GetFileName(openDialog.FileName);
                this.Text = Path.GetFileName(openDialog.FileName);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(openDialog.FileName))
            {
                saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                richTextBox.SaveFile(saveDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            else
                saveAtMenuItem_Click(sender, e);
        }

        private void saveAtMenuItem_Click(object sender, EventArgs e)
        {
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveDialog.FileName, RichTextBoxStreamType.PlainText);
                saveDialog.FileName = Path.GetFileName(saveDialog.FileName);
                this.Text = Path.GetFileName(saveDialog.FileName);
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.ScrollToCaret();
        }

        private void richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenu.Show();
        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionFont = fontDialog.Font;
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionColor = colorDialog.Color;
        }        
    }
}
