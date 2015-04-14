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



namespace Pathfinder_Kingdom_Spreadsheet_Updater
{
    
    public partial class Form1 : Form
    {
        String oFile = null;
        String dFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSF_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOF_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDiag1 = new OpenFileDialog();

            oFileDiag1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx|All Files (*.*)|*.*";
            oFileDiag1.FilterIndex = 1;
            oFileDiag1.RestoreDirectory = true;
            oFileDiag1.CheckFileExists = true;
            oFileDiag1.AutoUpgradeEnabled = true;
            oFileDiag1.Multiselect = false;

            if (oFileDiag1.ShowDialog() == DialogResult.OK)
            {
            }
            oFile = oFileDiag1.FileName;
            OpenFileTextBox.Text = oFile;
        }
    }
}
