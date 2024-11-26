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

namespace B07CSHarp13
{
    public partial class WriteFile : Form
    {
        public WriteFile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
            //    StreamWriter sr = new StreamWriter("readfile.txt");
            //    //sr.WriteLine(content);
            //    sr.WriteLine(this.richTextBox1.Text);
            //    sr.Close();


            //}
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt|Show All Files (*.*)|*.*"; ;
            saveFileDialog1.Title = "Save an text File";
            saveFileDialog1.ShowDialog();
        //    System.IO.FileStream fs =
        //(System.IO.FileStream)saveFileDialog1.OpenFile();
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
            
            //fs.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK) { 
                //this.richTextBox1.Font = fontDialog1.Font;
                //this.richTextBox1.ForeColor = fontDialog1.Color;
                this.richTextBox1.SelectionFont = fontDialog1.Font;
                this.richTextBox1.SelectionColor = this.fontDialog1.Color;
            }
        }
    }
}
