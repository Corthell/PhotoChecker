using IMGOgranizer.Controler;
using IMGOgranizer.Infrastrucure;
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
using IMGOgranizer.View;
using IMGOgranizer.ViewControl;

namespace IMGOgranizer
{
    public partial class IMGOrganizer : Form
    {
        DataAccessControler dataAccessControler;

        public IMGOrganizer()
        {
            InitializeComponent();
            dataAccessControler = new DataAccessControler();
        }

        private void btChoseSourceFolderDialog_Click(object sender, EventArgs e)
        {
            tbPatchToSourceFolder.Text = dataAccessControler.SetPatchToSourceFolder(folderBrowserDialog);
        }

        private void btChoseDestinationFolderDialog_Click(object sender, EventArgs e)
        {
            tbPatchToDestinationFolder.Text = dataAccessControler.SetPatchToTargetFolder(folderBrowserDialog);
            btExecuteOperation.Enabled = true;
        }
        
        private void btExecuteOperation_Click(object sender, EventArgs e)
        {
            DataAccessControler dataAccessControler = new DataAccessControler();

            dataAccessControler.SetListAllFullPatchFilesInSourceDirectory();
            dataAccessControler.SetListAllFullPatchFilesInTargetDirectory();
            dataAccessControler.SetListOfFullPatchDetectedUniqueFilesNameToCopy();

            try
            {
                dataAccessControler.ExecuteTransferFiles(cbMoveCopiedFiles, tbNewDirectoryName.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            DetailsOperation detailsOperation = new DetailsOperation(dataAccessControler.GetPatchToSourceFolder(), dataAccessControler.GetListPatchToFile(TypeData.Unique),
                dataAccessControler.GetNumberOfFiles(TypeData.Source),
                dataAccessControler.GetNumberOfFiles(TypeData.Target),
                dataAccessControler.GetNumberOfFiles(TypeData.Unique));

            detailsOperation.Show();
            btExecuteOperation.Enabled = false;

        }
    }
}
