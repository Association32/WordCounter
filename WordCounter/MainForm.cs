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



namespace WordCounter
{
    public partial class MainForm : Form
    {
        private TextManager currText;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            textBoxAddress.Text = "";
            lblNrUnique.Text = "";
            lblNrWords.Text = "";
            btnOk.Enabled = false;
            btnSaveToFile.Enabled = false;
            btnShowList.Enabled = false;
            chckboxCapLEtters.Checked = true;
            currText = new TextManager("");
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            TextAdder newTextAdder = new TextAdder(currText);
            DialogResult result = newTextAdder.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(chckboxCapLEtters.Checked)
                {
                    currText.ToLower = true;
                }
                if(currText.CheckInput(currText.TextInput))
                {
                    btnOk.Enabled = true;
                }
            }
        }

        private void btnEditChar_Click(object sender, EventArgs e)
        {
            Removables myRemovables = new Removables(currText);
            DialogResult result = myRemovables.ShowDialog();
            if(result ==  DialogResult.OK)
            {
                
            }
        }

        private void btnEditException_Click(object sender, EventArgs e)
        {
            Exceptions myException = new Exceptions(currText);
            DialogResult result = myException.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(currText.CheckInput(currText.TextInput))
            {
                if (chckboxCapLEtters.Checked)
                {
                    currText.ToLower = true;
                }

                currText.Calculate();
                lblNrWords.Text = currText.NrTotal.ToString();
                lblNrUnique.Text = currText.NrUniques.ToString();
                btnSaveToFile.Enabled = true;
                btnShowList.Enabled = true;
            }
            else
            {

                MessageBox.Show("The input does not appear to be correct. \nCheck your input, characters and exceptions.");
            }
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpener = new OpenFileDialog();
            fileOpener.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = fileOpener.ShowDialog();
            if (result ==  DialogResult.OK)
            {
                string fileName = fileOpener.FileName;
                string[] fileStringArray = File.ReadAllLines(fileName);
                string input = "";
                for (int i = 0; i<fileStringArray.Length; i++)
                {
                    string newString = fileStringArray[i];
                    newString = newString.Trim();
                    newString += " ";
                    input += newString;
                }
                currText.TextInput = input;
                textBoxAddress.Text = fileName;
                if (currText.CheckInput(currText.TextInput))
                {
                    btnOk.Enabled = true;
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileOpener = new SaveFileDialog();
            fileOpener.Filter = "txt files (*.txt)|*.txt|xls files (*.xls)|*.xls";
            DialogResult result =  fileOpener.ShowDialog();
            string fileName = fileOpener.FileName;

            if(result == DialogResult.OK)
            {
                File.WriteAllText(fileName, currText.SaveString());
            }
            
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Table newTable = new Table(currText);
            newTable.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(textBoxAddress.Text.EndsWith(".txt"))
            {
                string fileLocation = textBoxAddress.Text;
                try
                {
                    currText.TextInput = File.ReadAllText(fileLocation).Trim();
                    if (currText.CheckInput(currText.TextInput))
                    {
                        btnOk.Enabled = true;
                    }
                }
                catch(FileNotFoundException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch
                {
                    MessageBox.Show("An unknown error occured. Check your input");
                }
            }
            else
            {
                MessageBox.Show("Use .txt files only.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }
    }
}
