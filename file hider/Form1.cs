using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_hider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //choosin file to hide
            openFileDialog1.Title = "file to hide";
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //choosing file to hide inside of
            openFileDialog2.Title = "file to hide the file inside of";
            openFileDialog2.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hiding the file
            saveFileDialog1.Title = "where to hide the file";

            saveFileDialog1.FileName = openFileDialog2.FileName;
            saveFileDialog1.ShowDialog();

            System.Diagnostics.Process.Start("CMD.exe", "/C copy /b \"" + openFileDialog2.FileName + "\"+\"" + openFileDialog1.FileName + "\" \"" + saveFileDialog1.FileName + "\"");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //selected the file to hide
            label1.Text = openFileDialog1.FileName;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            label2.Text = openFileDialog2.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
        }
    }
}
