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
    partial class Table : Form
    {
        TextManager thisTextManager;
        public Table(TextManager newTextManager)
        {
            InitializeComponent();
            thisTextManager = newTextManager;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dataGridResult.AutoGenerateColumns = true;
            for(int i = 0; i<thisTextManager.UniqueWords.Length; i++)
            {
                if(thisTextManager.UniqueWords[i]!=null)
                {
                    dataGridResult.Rows.Add(new object[] { thisTextManager.UniqueWords[i].Word, thisTextManager.UniqueWords[i].frequency });
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
