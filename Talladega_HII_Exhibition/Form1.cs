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

        /* Load text file and display contents in a textbox */
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            string line;
            int counter = 0;

            // Open the selected file to read.
            // System.IO.Stream fileStream = openFileDialog1.File.OpenRead();

            /* Throw exception if there is no input file */
            try
            {
                switch(openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        System.Diagnostics.Debug.Print("Exception: Press OK");
                        break;
                    case DialogResult.Cancel:
                        System.Diagnostics.Debug.Print("Exception: Press Cancel");
                        return;
                    default:
                        return;
                }
                //if (nResult == DialogResult.OK)
                //{
                //   System.Diagnostics.Debug.Print("Exception: Press OK");
                //}
                //else if (nResult == DialogResult.Cancel)
                //{
                //   System.Diagnostics.Debug.Print("Exception: Press Cancel");
                //  return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
            while ((line = sr.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                System.Diagnostics.Debug.Print(line);
                textBox1.AppendText(line + "\n");
                    counter++;
                    System.Diagnostics.Debug.Print("counter = {0}", counter);
            }
            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* Clear text in textbox */
        private void Clear_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            return;
        }

        /* Close window */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
