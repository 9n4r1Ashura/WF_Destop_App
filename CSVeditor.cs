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

namespace Practice_Project2WFA
{
    public partial class CSVeditor : Form
    {
        /*-------------------------------------------------------------Variables--------------------------------------------------------------------------------*/

        private string File_Path = "";
 
        /*-----------------------------------------------------------Variables End--------------------------------------------------------------------------------*/







        /*-------------------------------------------------------------Constructor--------------------------------------------------------------------------------*/
        public CSVeditor()
        {
            InitializeComponent();
        }
        /*-----------------------------------------------------------Constructor End--------------------------------------------------------------------------------*/



        /*------------------------------------------------------------Search Button--------------------------------------------------------------------------------*/
        /*
         *Used to select csv file.
         */
        private void Search_File_Button_Click(object sender, EventArgs e)
        {
            openFileDialog_Search_CSV.ShowDialog();
        }
        /*-----------------------------------------------------------Search Button End--------------------------------------------------------------------------------*/







        /*------------------------------------------------------------File Path Text Box--------------------------------------------------------------------------------*/
        /*
         *Used to do some functions when the text inside Text Box of File Path goes through any changes.
         */
        private void File_Path_Text_Box_TextChanged(object sender, EventArgs e)
        {
            if (!File_Path_Text_Box.Text.Equals(""))
            {
                File_Path_Text_Box_Locker.Enabled = true;
            }
            else 
            {
                File_Path = "";

                File_Path_Text_Box_Locker.Checked = false;

                File_Path_Text_Box_Locker.Enabled = false;

                Problem_Msg.Text = "";
            }
        }
        /*----------------------------------------------------------File Path Text Box End--------------------------------------------------------------------------------*/








        /*-------------------------------------------------------------File Path Text Box Locker--------------------------------------------------------------------------------*/
        /*
         *Used to do some functions when the Text Box of File Path is Locked for Use(Editing).
         */
        private void File_Path_Text_Box_Locker_CheckedChanged(object sender, EventArgs e)
        {

            if (File_Path_Text_Box_Locker.Checked)
            {
                string fname = File_Path_Text_Box.Text;

                fname.Replace("\\", "\\\\");

                if (file_validity_checker(fname))
                {
                    File_Path_Text_Box.Enabled = false;

                    File_Path = fname;

                    Problem_Msg.Text = "Ready for Editing!";

                    ChangeSection.Enabled = true;

                    Lock_Seperator.Enabled = false;


                }
                else 
                {
                    File_Path = "";

                    File_Path_Text_Box_Locker.Checked = false;
                    
                    ChangeSection.Enabled = false;

                    Problem_Msg.Text = "Incorrect path!";

                }

            }
            else 
            {
                File_Path = "";

                File_Path_Text_Box.Enabled = true;

                Problem_Msg.Text = "";

                ChangeSection.Enabled = false;
            }
        }
        /*-----------------------------------------------------------File Path Text Box Locker End--------------------------------------------------------------------------------*/








        /*------------------------------------------------------------File Selector Dialog Functionality--------------------------------------------------------------------------------*/
        /*
         *Used to do some functions when the any file is selected through the File Selector Dialog opened by Search File Button.
         */
        private void openFileDialog_Search_CSV_FileOk(object sender, CancelEventArgs e)
        {
            string filename = openFileDialog_Search_CSV.FileName;

            if (File_Path_Text_Box.Enabled)
            {
                File_Path_Text_Box.Text = filename;
            }
            
        }
        /*-----------------------------------------------------------File Selector Dialog Functionality End--------------------------------------------------------------------------------*/








        /*------------------------------------------------------------File Validity Checker Utility--------------------------------------------------------------------------------*/
        /*
         *Used to check if file path provided is correct.
         */
        private bool file_validity_checker(string filepath) 
        {
            if (filepath.Length >= 5)
            {
                if (filepath.Substring(filepath.Length - 4, 4).Equals(".csv"))
                {
                    FileInfo fileinfo = new FileInfo(filepath);

                    if (fileinfo.Exists)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
            
        }
        /*-----------------------------------------------------------File validity checker Utility End--------------------------------------------------------------------------------*/



        /*-----------------------------------------------------------UserInput Seperator Lock--------------------------------------------------------------------------------*/
        /*
         * Locks the Seperator provided.
         */
        private void Lock_Seperator_CheckedChanged(object sender, EventArgs e)
        {
            if (Lock_Seperator.Checked)
            {
                Coloumn_Number.Items.Clear();

                Seperator_UserInput.Enabled = false;

                for (int i = 0; i < Convert.ToInt32(Detected_Provided_Colooumn_Num.Text); i++)
                {
                    Coloumn_Number.Items.Add(i + 1);
                }
                Coloumn_Number.Enabled = true;

                Coloumn_Number.SelectedIndex = 0;

                Console.WriteLine(Coloumn_Number.SelectedIndex);
            }
            else
            {
                Seperator_UserInput.Enabled = true;

                Coloumn_Number.Items.Clear();

                Coloumn_Number.Enabled = false;

                Coloumn_Number.ResetText();

                Console.WriteLine(Coloumn_Number.SelectedIndex);
            }
        }
        /*-----------------------------------------------------------UserInput Seperator End--------------------------------------------------------------------------------*/







        /*-----------------------------------------------------------Seperator UserInput Text Changed Event--------------------------------------------------------------------------------*/
        /*
         * Starts when there is change in Seperator_UserInput Textbox
         */

        private void Seperator_UserInput_TextChanged(object sender, EventArgs e)
        {
            if (!Seperator_UserInput.Text.Equals(""))
            {
                FileStream fs = new FileStream(File_Path, FileMode.Open);

                StreamReader sr = new StreamReader(fs);

                string[] FirstLine = sr.ReadLine().Split(Seperator_UserInput.Text.ToCharArray());

                Detected_Provided_Colooumn_Num.Text = FirstLine.Length.ToString();

                sr.Close();

                fs.Dispose();

                Lock_Seperator.Enabled = true;

            }
            else
            {
                Lock_Seperator.Enabled = false;

                Detected_Provided_Colooumn_Num.Text = null;
            }
        }
        /*-----------------------------------------------------------Seperator UserInput Text Changed Event End--------------------------------------------------------------------------------*/







        /*------------------------------------------------------------On Form Load--------------------------------------------------------------------------------*/
        /*
         *Used to do some functions when the Form Loads for the first time.
         */
        private void CSVeditor_Load(object sender, EventArgs e)
        {
            File_Path = "";

            File_Path_Text_Box.Text = "";
            
            File_Path_Text_Box_Locker.Enabled = false;

            ChangeSection.Enabled = false;

            Problem_Msg.Text = "";
            
        }

        private void Coloumn_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Coloumn_Number.SelectedIndex);
        }
        /*----------------------------------------------------------On Form Load End--------------------------------------------------------------------------------*/

    }
}
