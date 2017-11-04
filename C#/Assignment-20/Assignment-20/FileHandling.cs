using Assignment_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesAndFiles
{
    class FileHandling
    {
        static void Main(string[] args)
        {
            FileOperation file = new FileOperation();
            file.Write();
            file.Read();
            file.DriveInfos();
            file.DirectoryInfo();
            file.DirectoryPath();
            file.CompreesionFile();
            Console.ReadLine();
        }
    }
}
