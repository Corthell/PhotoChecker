using IMGOgranizer.Infrastrucure;
using IMGOgranizer.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace IMGOgranizer.Controler
{
    class DataAccessControler : DataModel
    {
        #region SetPatchToSourceFolder
        public string SetPatchToSourceFolder(FolderBrowserDialog folderBrowserDialog)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SourceFolderPatch = folderBrowserDialog.SelectedPath;
            }

            return SourceFolderPatch;
        } 
        #endregion
        #region GetPatchToSourceFolder
        public string GetPatchToSourceFolder()
        {
            return SourceFolderPatch;
        } 
        #endregion
        
        #region SetPatchToTargetFolder
        public string SetPatchToTargetFolder(FolderBrowserDialog folderBrowserDialog)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                TargetFolderPatch = folderBrowserDialog.SelectedPath;
            }

            return TargetFolderPatch;
        } 
        #endregion
        #region GetPatchToTargetFolder
        public string GetPatchToTargetFolder()
        {
            return TargetFolderPatch;
        } 
        #endregion

        #region SetListAllFullPatchFilesInSourceDirectory

        public void SetListAllFullPatchFilesInSourceDirectory()
        {
            ListAllFullPatchOfFilesInSourceDirectory = OperationsControler.SearchIndicatedFolder(SourceFolderPatch, ResultMode.OnlyFileName);
        }

        #endregion
        #region SetListAllFullPatchFilesInTargetDirectory
            public void SetListAllFullPatchFilesInTargetDirectory()
        {
            ListAllFullPatchOfFilesInTargetDirectory = OperationsControler.SearchIndicatedFolder(TargetFolderPatch, ResultMode.OnlyFileName);
        } 
        #endregion
        #region SetListOfFullPatchDetectedUniqueFilesNameToCopy
        public void SetListOfFullPatchDetectedUniqueFilesNameToCopy()
        {
            ListOfFullPatchDetectedUniqueFilesToCopy = OperationsControler.FindUniqueFilesFromSourceAndTargetDirectories(
                OperationsControler.SearchIndicatedFolder(SourceFolderPatch, ResultMode.OnlyFileName),
                OperationsControler.SearchIndicatedFolder(TargetFolderPatch, ResultMode.OnlyFileName));
        } 
        #endregion

        #region GetNumberOfFiles
        public int GetNumberOfFiles(TypeData folderType)
        {
            switch (folderType)
            {
                case TypeData.Source:
                    return OperationsControler.CountNumberOfFilesInFolder(ListAllFullPatchOfFilesInSourceDirectory);

                case TypeData.Target:
                    return OperationsControler.CountNumberOfFilesInFolder(ListAllFullPatchOfFilesInTargetDirectory);

                case TypeData.Unique:
                    return OperationsControler.CountNumberOfFilesInFolder(ListOfFullPatchDetectedUniqueFilesToCopy);

                default:
                    return -1;
            }
        } 
        #endregion
  
        #region GetListPatchToFile
        public List<string> GetListPatchToFile(TypeData typeData)
        {
            switch (typeData)
            {
                case TypeData.Source:
                    return (List<string>)ListAllFullPatchOfFilesInSourceDirectory;

                case TypeData.Target:
                    return (List<string>)ListAllFullPatchOfFilesInTargetDirectory;

                case TypeData.Unique:
                    return (List<string>)ListOfFullPatchDetectedUniqueFilesToCopy;

                default:
                    return null;
            }
        } 
        #endregion

        #region ExecuteTransferFiles
        public void ExecuteTransferFiles(CheckBox moveFiles, string newFolderName)
        {
            if (moveFiles.Checked)
                OperationsControler.TransferFiles(SourceFolderPatch, TargetFolderPatch, ListOfFullPatchDetectedUniqueFilesToCopy, TransferType.Move, newFolderName);
            else
                OperationsControler.TransferFiles(SourceFolderPatch, TargetFolderPatch, ListOfFullPatchDetectedUniqueFilesToCopy, TransferType.Copy, newFolderName);
        } 
        #endregion

    }
}
