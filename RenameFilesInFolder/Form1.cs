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

namespace RenameFilesInFolder
{
    public partial class frmRenameFiles : Form
    {
        public frmRenameFiles()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtPath.Text)) { MessageBox.Show(this, "Path is required."); return; }
                if (String.IsNullOrWhiteSpace(txtPrefix.Text)) { MessageBox.Show(this, "Prefix is required."); return; }
                if (String.IsNullOrWhiteSpace(txtBeginIn.Text)) { MessageBox.Show(this, "Begin In is required."); return; }
                txtProcess.Clear();
                
                var filePaths = Directory.GetFiles(txtPath.Text);
                int beginIn = Int32.Parse(txtBeginIn.Text);

                foreach (string file in filePaths)
                {
                    if (!file.ToLower().Contains("ova")) { 
                    
                        string oldFileName = file.Substring(file.LastIndexOf("\\")).Replace("\\", "");
                        string ext = oldFileName.Substring(oldFileName.LastIndexOf("."));
                        string newFileName = txtPrefix.Text + beginIn.ToString("00") + ext;
                        System.IO.File.Move(file, txtPath.Text+"\\"+ newFileName);

                        txtProcess.AppendText(oldFileName + " -> " + newFileName);
                        txtProcess.AppendText(Environment.NewLine);
                        beginIn++;
                    }
                }
                // Console.WriteLine(Path.GetFileName(file));

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }

        }
    }
}
