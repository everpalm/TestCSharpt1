using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Talladega_HII_Exhibition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            string line;
            int counter = 0;
                // Open the selected file to read.
               // System.IO.Stream fileStream = openFileDialog1.File.OpenRead();
               
                try
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        System.Diagnostics.Debug.Print("測試訊息！！！Form1！！！");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    textBox1.AppendText(line + "\n");
                    counter++;
                    System.Diagnostics.Debug.Print("counter = {0}", counter);
                }
                sr.Close();      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
