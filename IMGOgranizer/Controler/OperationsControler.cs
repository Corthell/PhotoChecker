using IMGOgranizer.Infrastrucure;
using IMGOgranizer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IMGOgranizer.Controler
{
    public static class OperationsControler
    {
        #region SearchIndicatedFolder
        public static IEnumerable<string> SearchIndicatedFolder(string patchToFolder, ResultMode resultMode, string patternSearch = "*")
        {
            if (resultMode == ResultMode.OnlyFileName)
            {
                var resultList =
                    from files in Directory.EnumerateFiles(patchToFolder, patternSearch, SearchOption.AllDirectories)
                    select Path.GetFileName(files);

                return resultList;
            }
            else
            {
                var resultList =
                    from files in Directory.EnumerateFiles(patchToFolder, patternSearch, SearchOption.AllDirectories)
                    select files;

                return resultList;
            }
        } 
        #endregion

        #region FindUniqueFilesFromSourceAndTargetDirectories
        public static IEnumerable<string> FindUniqueFilesFromSourceAndTargetDirectories(IEnumerable<string> firstList, IEnumerable<string> secondList)
        {
            var resultList = firstList.Except(secondList).ToList();

            return resultList;
        } 
        #endregion

        #region CountNumberOfFilesInFolder
        public static int CountNumberOfFilesInFolder(IEnumerable<string> listOfFiles)
        {
            return listOfFiles.Count();
        }
        #endregion

        #region TransferFiles
        public static void TransferFiles(string sourceFolderPatch, string targetFolderPatch, IEnumerable<string> listFilesToTransfer, TransferType transferType, string newFolderName)
        {
            string newPatchToTransferFiles = String.Empty;

            newPatchToTransferFiles = newFolderName == "" ? $@"{targetFolderPatch}\New Files_{DateTime.Now.ToString("dd-MM-yy")}\" : $@"{targetFolderPatch}\{newFolderName}\";

            Directory.CreateDirectory($"{newPatchToTransferFiles}");

            if (transferType == TransferType.Copy)
            {
                foreach (var singlePathToSourceFile in listFilesToTransfer)
                {
                    File.Copy($@"{sourceFolderPatch}\{singlePathToSourceFile}", $@"{newPatchToTransferFiles}\{singlePathToSourceFile}");
                }
            }
            else
            {
                foreach (var singlePathToSourceFile in listFilesToTransfer)
                {
                    File.Move($@"{sourceFolderPatch}\{singlePathToSourceFile}", $@"{newPatchToTransferFiles}\{singlePathToSourceFile}");
                }
            }

            //TODO: Trzeba zmienic 1 i 2 argument aby to nie byla statyczna sciezka tylko indwidualna dla kazdego pliku z listy. Trzeba zrobic jakas dodatkowa funkcje ktora porowna nazwy plikow zawieraja sie w w liscie fullPatch. ehhh ;/


        } 
        #endregion
    }
}
