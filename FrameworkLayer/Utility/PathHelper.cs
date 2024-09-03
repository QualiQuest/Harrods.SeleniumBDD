using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrods_Project.FrameworkLayer.Utility
{
    public class PathHelper
    {
        public static string GetPathToFile(string fileName, string folderName = "") //if the file is not in a folder, the foldername will not be specified when the method GetPathToFile is called.
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            //var fileLocation = $"/{folderName}/{fileName}";// string interpolation for filelocation.
            var fileLocation = "";
            if (string.IsNullOrEmpty(folderName))
            {
                fileLocation = fileName;
            }

            else fileLocation = Path.Combine(folderName, fileName);

           

            var fullPath = Path.Combine(currentDirectory, fileLocation);
            return fullPath;
        }
    }
}
