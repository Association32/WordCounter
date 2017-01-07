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
    partial class Removables : Form
    {
        TextManager thisTextManager;

        public Removables(TextManager newTextManager)
        {
            InitializeComponent();
            thisTextManager = newTextManager;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            for(int i = 0; i< chckListBoxRemove.Items.Count; i++)
            {
                string text = chckListBoxRemove.GetItemText(chckListBoxRemove.Items[i]);
                bool inArray = false;
                for(int ii =0; ii< thisTextManager.Removables.Length;ii++)
                {
                    if (text == thisTextManager.Removables[ii].ToString())
                    {
                        inArray = true;
                    }
                }
                if(inArray)
                {
                    chckListBoxRemove.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int checkItems = 0;
            for(int i = 0; i< chckListBoxRemove.Items.Count; i++)
            {
                if (chckListBoxRemove.GetItemChecked(i))
                {
                    checkItems++;
                }
            }
            char[] newArray = new char[checkItems+1];

            int indexOfItem = 0;
            for (int i = 0; i < chckListBoxRemove.Items.Count; i++)
            {
                if (chckListBoxRemove.GetItemChecked(i))
                {
                    string text = chckListBoxRemove.GetItemText(chckListBoxRemove.Items[i]);
                    char toChar = text[0];
                    newArray[indexOfItem] = toChar;
                    indexOfItem++;
                }
            }
            newArray[checkItems] = ' ';
            thisTextManager.Removables = newArray;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            for(int i =0; i< chckListBoxRemove.Items.Count; i++)
            {
                chckListBoxRemove.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
