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
    public partial class Main : Form
    {
        public Main()
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


        #region myMethods
        // pass in the text box with zip info 
        private void Save_info(TextBox zip)
        {
            // todo validate data make sure input is not or does not contain a string 
            try
            {
                int their_zip = int.Parse(textBoxZip.Text);
                
                // write their zip to a file 
                string path = @"C:\Users\CaLs_Rig\PycharmProjects\Project3\Program\";
                string path_plus_filename = path + "users_zip_code.txt";

// FileStream makezip = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter writeZip = new StreamWriter( new FileStream(path_plus_filename, FileMode.OpenOrCreate,FileAccess.ReadWrite));
                their_zip.ToString();
                writeZip.Write(their_zip);
                writeZip.Close();


            }
            //todo fix both path and file not found error messages.
            catch (FileNotFoundException)
            {
                MessageBox.Show( " not found.", "File Not Found");

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show( " not found ", "Directory not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Exception");
            }

        
            catch (FormatException badinput)
            {
                MessageBox.Show("Invalid input. Enter a proper zip" + badinput.Message, "Zip Error", MessageBoxButtons.OK);
                textBoxZip.Focus();
                //todo get this working properly 
                //lblZip.ForeColor = ForeColor.ToKnownColor(Color.Red);
            }
        }

#endregion


        // Form load Events 
        private void Form1_Load(object sender, EventArgs e)
        {
            //when this form loads read the data from python into the rich text box. 
            string FloodText =
                " When this form loads it will be replaced by the python text. So this is just test text. If you are seeing this. Something is not configured right";

            string path = @"C:\Users\CaLs_Rig\PycharmProjects\Project3\Program\";

            string fileName = path + "Floodinfo.txt";

            try
            {
                // try to open the file that was creating using python companion app 
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader flood_nfo_from_stream = new StreamReader(fs);
                var test_found = flood_nfo_from_stream.ReadToEnd();

                rtbHelpful_Info.Text = test_found;
                // todo try this if current method doesn't work 
                // renamed richtextbox to trb rtbHelpful_Info
                // rtbHelpful_Info.Text = FloodText;
                fs.Close();

                // todo limit the amount of numbers that can be keyed in for zip code to 5
                textBoxZip.MaxLength = 5;


            }

            catch (FileNotFoundException)
            {
                MessageBox.Show(fileName + " not found.", "File Not Found");

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found ", "Directory not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Exception");
            }


// add this when i put in to its own method
//    finally
            //          {
            //            if (fs != null)
            //          {
            //            fs.Close();
            //      }
        }


        // this button click tells the system to go ahead and save the user input to request information for that zip code radius
        private void button_GetInfo_Click(object sender, EventArgs e)
        {
            // first save the info to a file for python to read 
            MessageBox.Show("Sending request please wait...");


            // if i had a status bar i would start filling it up to show user some visual progress. 
            Save_info(textBoxZip);
        }
    }
}

