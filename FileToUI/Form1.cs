using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileToUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string temp="";
            openFileDialog.ShowDialog();
            if(openFileDialog.FileName.EndsWith(".txt"))
            {
                Stream dat=openFileDialog.OpenFile();
                temp = File.ReadAllText(openFileDialog.FileName);
                string[] atts = temp.Split('\n');
                Fname.Text = atts[0].Split('=')[1] + " " + atts[1].Split('=')[1]; //cannot be bothered to optimize this
                Fyear.Text = atts[2].Split('=')[1];
                Fcity.Text = atts[3].Split('=')[1];
                Ffaculty.Text = atts[4].Split('=')[1];
                Frole.Text = atts[5].Split('=')[1];
                specific.Text = atts[6].Split('=')[0] +":";
                Fspecific.Text = atts[6].Split('=')[1];
                temp.Split('\n')[7].Split('=')[1] = (int.Parse(temp.Split('\n')[7].Split('=')[1]) + 1).ToString();
            }
            string path = openFileDialog.FileName;
            openFileDialog.Dispose();
            //if (temp!="") { File.WriteAllText(path, temp); }
        }
    }
}
