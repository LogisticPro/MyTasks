using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Task15
{
    public class FileWorker
    {
        public List<FileInfo> FindFile(DirectoryInfo path, string fileName)
        {
            List<FileInfo> files = new List<FileInfo>();

            files.AddRange(path.GetFiles(fileName).ToList());

            var directories = path.GetDirectories();

            foreach(var item in directories)
            {
                var a = FindFile(item, fileName);
                files.AddRange(a);
            }

            return files;
        }
    }
}
