using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordCounter
{
    partial class TextAdder : Form
    {
        private TextManager thisTextManager;

        public TextAdder(TextManager newTextManager)
        {
            InitializeComponent();
            thisTextManager = newTextManager;
            InitializeGUI();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string newString = "";
            string[] stringArray = textBoxAddText.Lines;
            for (int i = 0; i<stringArray.Length; i++)
            {
                newString += stringArray[i];
                newString = newString.Trim();
                newString += " ";
            }
            thisTextManager.TextInput = newString;            
        }

        private void InitializeGUI()
        {
            if(string.IsNullOrEmpty(thisTextManager.TextInput))
            {
                textBoxAddText.Text = "";
            }
            else
            {
                textBoxAddText.Text = thisTextManager.TextInput;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileOpener = new SaveFileDialog();
            fileOpener.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = fileOpener.ShowDialog();
            string fileName = fileOpener.FileName;
            string content = textBoxAddText.Text;

            if (result == DialogResult.OK)
            {
                File.WriteAllText(fileName, content);
            }

        }
    }
}
