using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMGOgranizer.View
{
    public partial class DetailsOperation : Form
    {
        public int NumberOfFilesInSourceDirectory { get; set; }
        public int NumberOfFilesInTargetDirectory { get; set; }
        public int NumberOfUniqueFilesToCopy { get; set; }
        private List<string> ListOfCopiedfiles { get; set; }

        public DetailsOperation(string sourceFolderPatch, IEnumerable<string> listOftransferedNameFiles, int numberOfFilesInSourceDirectory, int numberOfFilesInTargetDirectory, int numberOfUniqueFilesToCopy)
        {
            InitializeComponent();

            ListOfCopiedfiles = listOftransferedNameFiles.ToList();
            NumberOfFilesInSourceDirectory = numberOfFilesInSourceDirectory;
            NumberOfFilesInTargetDirectory = numberOfFilesInTargetDirectory;
            NumberOfUniqueFilesToCopy = numberOfUniqueFilesToCopy;

            lbNumberSourceFilesValue.Text = numberOfFilesInSourceDirectory.ToString();
            lbNumberTargetFilesValue.Text = numberOfFilesInTargetDirectory.ToString();
            lbNumberFilesToTransferValue.Text = numberOfUniqueFilesToCopy.ToString();
            lbTransferedValue.Text = numberOfUniqueFilesToCopy.ToString();

            foreach (var item in listOftransferedNameFiles)
            {
                rbPatchFiles.Text += $"{sourceFolderPatch}  {item}\n";
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
