using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Analyser
{
    /// <summary>
    /// Exposes methods for searching a local directory for files by file type and returning listings
    /// </summary>
    class DirSearch
    {
        /// <summary>
        /// Load the directory info into memory
        /// </summary> 
        /// <returns>DirectoryInfo</returns>
        /// <param name="d">Directory to be searched</param>
        private DirectoryInfo GetDirectory(string d)
        {
            var dir = new DirectoryInfo(d);
            return dir;
        }

        /// <summary>
        /// Load all files from the directory into IEnumerable
        /// </summary>
        /// <returns>IEnumerable</returns>
        /// <param name="d">Directory to be searched</param>
        private IEnumerable<FileInfo> CreateFileList(string d)
        {
            var fileList = GetDirectory(d).GetFiles("*.*", SearchOption.AllDirectories);
            return fileList;
        }

        /// <summary>
        /// Filter files based on extension type
        /// </summary>
        /// <returns>IEnumerable</returns>
        /// <param name="d">Direcroty to be searched</param>
        /// <param name="fe">Target file extension type</param>
        public IEnumerable<FileInfo> GetFiles(string fe, string d)
        {
            IEnumerable<FileInfo> fileQuery =
                from file in CreateFileList(d)
                where file.Extension == fe
                orderby file.Name
                select file;
            return fileQuery;
        }

        /// <summary>
        /// Test method - Prints results of query to console
        /// </summary>
        /// <param name="d">Direcroty to be searched</param>
        /// <param name="fe">Target file extension type</param>
        public void PrintQueryResults(string searchTerm, string directory)
        {
            //Execute the query. This might write out a lot of files!  
            foreach (FileInfo file in GetFiles(searchTerm, directory))
            {
                Console.WriteLine(file.FullName);
            }
        }        
    }
}
