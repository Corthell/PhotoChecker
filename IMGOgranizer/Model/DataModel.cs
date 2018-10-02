using IMGOgranizer.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMGOgranizer.Model
{
    class DataModel
    {
        protected static string SourceFolderPatch { get; set; }
        protected static string TargetFolderPatch { get; set; }

        protected IEnumerable<string> ListAllFullPatchOfFilesInSourceDirectory { get; set; }
        protected IEnumerable<string> ListAllFullPatchOfFilesInTargetDirectory { get; set; }
        protected IEnumerable<string> ListOfFullPatchDetectedUniqueFilesToCopy { get; set; }

        ///TODO: Implement methods for copying entire filders (new functionality).
        //protected IEnumerable<string> listAllDirectorysInSourceDirectory { get; set; }
        //protected IEnumerable<string> listAllDirectorysInTargetDirectory { get; set; }
        //protected IEnumerable<string> listOfDetectedUniqueDirectorysToCopy { get; set; }
    }
}
