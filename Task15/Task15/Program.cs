using System;
using System.IO;
using System.IO.Compression;
namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker = new FileWorker();

            var dir = new DirectoryInfo(@"D:\Ученье - свет\Practic");

            var list = fileWorker.FindFile(dir, "Doc.txt");

            if (list.Count != 0)
            {
                Console.WriteLine("It's ok!");

                foreach (var item in list)
                {                    
                    Console.WriteLine(item.Name);

                    var dest = item.DirectoryName + ".zip";

                    ZipFile.CreateFromDirectory(item.DirectoryName, dest);
                }               
            }
            else if(list.Count == 0)
            {
                throw new FileNotFoundException();
            }

            Console.ReadKey();
        }
    }
}
