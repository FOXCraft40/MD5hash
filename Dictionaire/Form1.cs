using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upDownMin_ValueChanged(object sender, EventArgs e)
        {
            #region CODE
            // handle error case
            if (upDownMin.Value == 0)
            {
                upDownMin.Value = 1;
            }

            if (upDownMin.Value == upDownMax.Value + 1)
            {
                upDownMax.Value++;
            }
            #endregion
        }

        private void upDownMax_ValueChanged(object sender, EventArgs e)
        {
            #region CODE
            // handle error case
            if (upDownMax.Value == 0)
            {
                upDownMax.Value = 1;
            }
            if (upDownMax.Value == upDownMin.Value - 1)
            {
                upDownMin.Value--;
            }
            #endregion
        }

        private void alphaMin_CheckStateChanged(object sender, EventArgs e)
        {
            updateUsedChar();
        }
        private void alphaCaps_CheckStateChanged(object sender, EventArgs e)
        {
            updateUsedChar();
        }

        private void numeral_CheckStateChanged(object sender, EventArgs e)
        {
            updateUsedChar();
        }
        private void updateUsedChar()
        {
            #region CODE
            string _alphaMin = "abcdefghijklmnopqrstuvwxyz";
            string _alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string _numeral = "0123456789";

            usedChar.Text = "";
            if(alphaMin.Checked)
            {
                usedChar.Text += _alphaMin;
            }
            if (alphaCaps.Checked)
            {
                usedChar.Text += _alphaCaps;
            }
            if (numeral.Checked)
            {
                usedChar.Text += _numeral;
            }
            #endregion
        }

        private void usedChar_TextChanged(object sender, EventArgs e)
        {
            #region CODE
            // avoid cupliced char and `Enter` Char
            usedChar.Text = string.Join("", new HashSet<char>(usedChar.Text));
            usedChar.Text = usedChar.Text.Replace(Environment.NewLine, "");
            #endregion 
        }

        private void usedChar_KeyDown(object sender, KeyEventArgs e)
        {
            #region CODE
            // Go to Generate if Enter is pressed
            if (e.KeyCode == Keys.Enter)
            {
                generateBtn_Click(this, new EventArgs());
            }
            #endregion
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            #region CODE
            var min = (double) upDownMin.Value;
            var max = (double) upDownMax.Value;
            var l = usedChar.Text.Length;
            double size = 0;
            string msg;

            // compute the size of the deictionary 
            for (;min <= max; min++)
            {
                size += (Math.Pow(l, min) * min) + Math.Pow(l, min);
            }
            var moSize = Decimal.Truncate((decimal) size / 1000000);
            var goSize = Decimal.Truncate(moSize / 1000);

            // affiche un message adapter celon la taille du fichier generer
            if (size < 100000)
            {
                msg = String.Format("Le fichier va peser {0,0} octet !", size);

            } else if (moSize < 10000)
            {
                msg = String.Format("Le fichier va peser {0,0} Mega-octet !", moSize);

            } else
            {
                msg = String.Format("Le fichier va peser {0,0} Giga-octet !", goSize);
            }

            // If the user confirm, we can ask for a save emplacement.
            if (MessageBox.Show(msg, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // code sample from https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-save-files-using-the-savefiledialog-component
                // Displays a SaveFileDialog so the user can save the Dictionary
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (.txt) | *.txt";
                saveFile.DefaultExt = "txt"; 
                saveFile.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFile.FileName != "")
                {
                    // Open the write stream
                    System.IO.StreamWriter w = new System.IO.StreamWriter((System.IO.FileStream)saveFile.OpenFile());
                    // setup progress bar
                    progressBar.Visible = true;
                    progressBar.Maximum = (int) upDownMax.Value;
                    for(decimal i = upDownMin.Value; i <= upDownMax.Value; i ++)
                    {
                        printAllKLengthRec(usedChar.Text, "", usedChar.Text.Length, i, w);
                        progressBar.Value = (int)i;
                    }
                    // remove progress bar
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    w.Close();
                }
            }
            #endregion
        }


        #region FUNCTION FROM : https://www.geeksforgeeks.org/print-all-combinations-of-given-length/
        void printAllKLengthRec(string set, string prefix, decimal n, decimal k, System.IO.StreamWriter w)
        {

            // Base case: k is 0, 
            // print prefix 
            if (k == 0)
            {
                w.WriteLine(prefix);
                w.Flush();
                return;
            }

            // One by one add all characters  
            // from set and recursively  
            // call for k equals to k-1 
            for (int i = 0; i < n; i++)
            {
                string newPrefix;

                // Next character of input added 
                newPrefix = prefix + set[i];

                // k is decreased, because  
                // we have added a new character 
                printAllKLengthRec(set, newPrefix, n, k - 1, w);
            }

        }
        #endregion
    }
}
