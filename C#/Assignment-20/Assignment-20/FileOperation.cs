using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20
{
    public class FileOperation
    {
        public void Write()
        {
            string[] names = { "Rahul", "Krishna", "Swati" };
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\tushar.srivastava\Documents\Names.txt"))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("File can not be right");
            }
        }
        public void Read()
        {
            using(StreamReader sr=new StreamReader(@"C:\Users\tushar.srivastava\Documents\Names.txt"))
            {
                string line="";
                while((line=sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
                FileInfo fi = new FileInfo(@"C:\Users\tushar.srivastava\Documents\Names.txt");
                fi.IsReadOnly = true;
                
            }
        }
        public void DriveInfos()
        {
            
             DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady &&drive.Name=="C:\\")
                {
                    Console.WriteLine("Drive Name : " + drive.Name);
                    Console.WriteLine("Drive Volume name : " + drive.VolumeLabel);
                    Console.WriteLine("Drive Format : " + drive.DriveFormat);
                    Console.WriteLine("Drive Type : " + drive.DriveType);
                    Console.WriteLine("Drive root directory name : " + drive.RootDirectory);
                    Console.WriteLine("Drive free space: " + drive.AvailableFreeSpace);
                    Console.WriteLine("Total Free space on the drive : " + drive.TotalFreeSpace);
                    Console.WriteLine("Total disk size : " + drive.TotalSize);
                    Console.WriteLine();
                }
            }
            
        }
        public void DirectoryInfo()
        {
            DirectoryInfo mydir = new DirectoryInfo(@"C:\Users\tushar.srivastava\Documents");
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }
        }
        public void DirectoryPath()
        {
            string path=@"C:\Users\tushar.srivastava\Documents\project.zip";
            string DirectoryName=Path.GetDirectoryName(path);
            Console.WriteLine("Directory Path is {0}\nDirectoryName is {1}",path,DirectoryName);
        }
        public void CompreesionFile()
        {
            DirectoryInfo DirectoryPath = new DirectoryInfo(@"C:\Users\tushar.srivastava\Documents\DemoProject");
            foreach (FileInfo fileToCompress in DirectoryPath.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {

                    using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                    {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                           CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);

                        }

                        FileInfo info = new FileInfo(DirectoryPath + "\\" + fileToCompress.Name + ".gz");
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                        fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                    }
                }
            }
            }
        }
    }
    

