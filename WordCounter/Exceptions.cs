using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    partial class Exceptions : Form
    {
        private TextManager thisTextManager;
        public Exceptions(TextManager newTextManager)
        {
            InitializeComponent();
            thisTextManager = newTextManager;
            InitializeGUI();
            UpdateGUI();
        }

        private void InitializeGUI()
        {
            textBoxAdd.Text = "";
            
            if(thisTextManager.ExceptionWords.Length<=0)
            {
                WordForm[] newArray = new WordForm[1];
                thisTextManager.ExceptionWords = newArray;
            }
            
            
        }

        private void UpdateGUI()
        {
            listBoxExceptions.Items.Clear();
            if (thisTextManager.ExceptionWords != null)
            {
                for (int i = 0; i < thisTextManager.ExceptionWords.Length; i++)
                {
                    if (thisTextManager.ExceptionWords[i] != null)
                    {
                        listBoxExceptions.Items.Add(thisTextManager.ExceptionWords[i].Word);
                    }
                }
            }
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            textBoxAdd.Text = "";

        }

        /// <summary>
        /// Kontrollerar att textboxen inte är tom elelr att texten redan finns i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBoxAdd.Text.Length>0)
            {
                bool notInList = true;
                for(int i = 0; i<listBoxExceptions.Items.Count; i++)
                {
                    if(textBoxAdd.Text == listBoxExceptions.Items[i].ToString())
                    {
                        notInList = false;
                    }
                }
                if(notInList)
                {
                    string newText = textBoxAdd.Text;
                    newText = newText.Trim();
                    thisTextManager.AddException(newText);
                }
                else
                {
                    MessageBox.Show("This exception is allready added to the list.");
                }
                
                
            }
            UpdateGUI();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(textBoxAdd.Text.Length >0)
            {
                string word = textBoxAdd.Text.Trim();
                int indexer = listBoxExceptions.SelectedIndex+1;
                WordForm[] newArray = new WordForm[thisTextManager.ExceptionWords.Length];
                for (int i = 0; i<thisTextManager.ExceptionWords.Length; i++)
                {
                    if(i== indexer)
                    {
                        newArray[i] = new WordForm(word);
                    }
                    else
                    {
                        newArray[i] = thisTextManager.ExceptionWords[i];
                    }
                }

                thisTextManager.ExceptionWords = newArray;
                UpdateGUI();

            }
        }

        private void listBoxExceptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                int indexer = listBoxExceptions.SelectedIndex;
                if (indexer >= 0)
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    textBoxAdd.Text = thisTextManager.ExceptionWords[indexer].Word;
                }
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexer = listBoxExceptions.SelectedIndex+1;
            thisTextManager.DeleteException(indexer);
            UpdateGUI();
        }
    }
}
