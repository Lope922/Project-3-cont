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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region button click events
        private void textBoxZip_Click(object sender, EventArgs e)
        {
                textBoxZip.Clear();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            // maybe close file stream if it hasn't been closed , and release any resrouces that were openend and used after this was written
        }

        #endregion




        // Form load Events 
        private void Form1_Load(object sender, EventArgs e)
        {
            //when this form loads read the data from python into the rich text box. 
            string FloodText = " When this form loads it will be replaced by the python text. So this is just test text. ";

            // renamed richtextbox to trb rtbHelpful_Info
            rtbHelpful_Info.Text = FloodText;

        }
    }
}
