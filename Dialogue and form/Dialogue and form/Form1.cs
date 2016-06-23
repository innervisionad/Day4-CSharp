using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogue_and_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Textfiles (*.txt)|*.txt|All files (*.*)|*.*";

            // if the file dialig opens successufully and the filename
            // entered is longer than 0
            if((openFileDialog1.ShowDialog() == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); 
            }

        }

        private void buttonColorchange_Click(object sender, EventArgs e)
        {
            //selects the color from the dialog ONLY if OK is clicked
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            //create a mew Form2 object
            Form2 nextForm = new Form2();
            //show the nnew form
            nextForm.Show();
            //hide the current form
            this.Hide();
            //set the previous form to be this form
            FormState.previousPage = this;
        }
    }
    public static class FormState
    {
        public static Form previousPage;
    }

}
