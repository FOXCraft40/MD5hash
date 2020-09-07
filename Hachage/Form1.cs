using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hachage
{
    public partial class Form1 : Form
    {
        #region CLASS ATRIBUTE
        // we need store the dictionary
        List<string> dictionary;
        decimal dl;
        // t is for `tentaives`
        decimal t;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        // Event "click on setting button"
        private void setting_Click(object sender, EventArgs e)
        {
            #region CODE
            // Show `Open File Dialog` for select the dictionary
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Word dictionary (*.txt)|*.txt";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Open and read the file (also update the "dictionary lenght"
                System.IO.StreamReader r = new System.IO.StreamReader((System.IO.FileStream)openFile.OpenFile());
                dictionary = new List<string>();
                string word;
                while ((word = r.ReadLine()) != null)
                {
                    dictionary.Add(word);
                }
                dl = dictionary.Count;
                wordCount.Text = Convert.ToString(dl);

                // Only Enable `validate button` if the hash is correct length and an dictionary is load.
                if (userHash.TextLength == 32)
                {
                    button1.Enabled = true;
                }
            }
            #endregion
        }

        // update `tentative` label and `timer`
        private void updateLabel(DateTime startTime)
        {
            #region CODE
            DateTime endTime = DateTime.Now;
            var dif = (endTime - startTime).TotalSeconds;
            var timeSpan = TimeSpan.FromSeconds(dif);
            label5.Text = String.Format("{0}m{1}s", timeSpan.Minutes, timeSpan.Seconds);
            tentativeCount.Text = String.Format("{0} / {1}", t, dl);
            tentativeCount.Visible = true;
            label5.Visible = true;
            #endregion
        }

        // event "Click on validate button"
        private void button1_Click(object sender, EventArgs e)
        {
            #region CODE
            bool found = false;
            string uh = userHash.Text.ToUpper();
            System.Security.Cryptography.MD5 h = System.Security.Cryptography.MD5.Create();
            t = 0;
            progressBar1.Maximum = (int) dl;
            DateTime startTime = DateTime.Now;

            // disable all useless info
            tentativeCount.Visible = false;
            label5.Visible = false;
            noMatch.Visible = false;
            userHash.Enabled = false;
            button1.Enabled = false;
            foreach (string word in dictionary)
            {
                // increment the `tentative`
                t++;
                progressBar1.Value++;

                #region CODE FROM :https://devblogs.microsoft.com/csharpfaq/how-do-i-calculate-a-md5-hash-from-a-string/
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(word);
                byte[] hash = h.ComputeHash(inputBytes);
                // Convert To Readable Hexadecimal
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    s.Append(hash[i].ToString("X2"));
                }
                #endregion

                // check correspondence
                if (s.ToString() == uh)
                {
                    found = true;
                    progressBar1.Value = progressBar1.Maximum;
                    updateLabel(startTime);
                    System.Windows.Forms.MessageBox.Show(String.Format("Votre hachage :\n{0}\n\nCorrespond au mot  suivant :\n{1}", uh, word));
                    break;
                }
            }
            if (!found)
            {
                updateLabel(startTime);
                noMatch.Visible = true;
            }
            progressBar1.Value = 0;
            userHash.Enabled = true;
            button1.Enabled = true;
            #endregion
        }

        private void userHash_TextChanged(object sender, EventArgs e)
        {
            #region CODE
            // Only Enable `validate button` if the hash is correct length and an dictionary is load.
            if (userHash.TextLength == 32 && dl != 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            #endregion
        }
    }
}
