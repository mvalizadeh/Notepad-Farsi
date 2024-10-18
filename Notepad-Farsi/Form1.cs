using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Farsi
{
    public partial class Form1 : Form
    {

        bool changeBody = false;
        string savePath = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void چسباندنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(body.SelectedText);
        }

        private void واگردToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void سندجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (changeBody)
            {
                DialogResult dialogResult = MessageBox.Show("تغییراتی در سند ایجاد شده است، آیا مایل به ذخیره تغییرات هستید؟", "ذخیره سند", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    var resultSave = saveFileDialog1.ShowDialog();
                    if (resultSave == DialogResult.OK)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                        {
                            streamWriter.Write(body.Text);
                        }
                    }
                    body.Text = "";
                    changeBody = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    body.Text = "";
                    changeBody = false;
                }
            }
            else
            {
                body.Text = "";
            }
        }

        private void body_TextChanged(object sender, EventArgs e)
        {
            changeBody = true;
            List<string> list = new List<string>();
            list.Add(body.Text);
        }

        private void mnuOpenDocument_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
                {
                    body.Text = streamReader.ReadToEnd();
                    changeBody = false;
                }

            }
        }

        private void mnuOpenNewWindow_Click(object sender, EventArgs e)
        {
            string pr = Process.GetCurrentProcess().ProcessName;
            Process.Start(pr);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (savePath != "")
            {
                using (StreamWriter sr = new StreamWriter(savePath))
                {
                    sr.Write(body.Text);
                }
            }
            else
            {
                var resultSave = saveFileDialog1.ShowDialog();
                if (resultSave == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                    {
                        streamWriter.Write(body.Text);
                    }
                    savePath = saveFileDialog1.FileName;
                }

            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            var resultSave = saveFileDialog1.ShowDialog();
            if (resultSave == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    streamWriter.Write(body.Text);
                }
                savePath = saveFileDialog1.FileName;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            body.Font = fontDialog1.Font;

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changeBody)
            {
                DialogResult dialog = MessageBox.Show("آیا مایل به ذحیره سند هستید؟", "ذخیره سند", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    mnuSave_Click(null, null);
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            body.SelectedText += Clipboard.GetText();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            چسباندنToolStripMenuItem_Click(null, null);
            body.SelectedText = "";
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            body.SelectAll();
        }

        private void mnuDatetime_Click(object sender, EventArgs e)
        {
            body.SelectedText += DateTime.Now;
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
            printDocument1.Print();
        }

        
    }
}
