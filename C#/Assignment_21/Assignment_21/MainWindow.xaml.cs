using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using System.Collections.Generic;
using CsvHelper;

namespace Assignment_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "csv file (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\tushar.srivastava\Documents\visual studio 2013\Projects\Assignment_21\Assignment_21\Assignment-21(a)";
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Content.Text=Path.GetFileName(filename);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\tushar.srivastava\Documents\visual studio 2013\Projects\Assignment_21\Assignment_21\Assignment-21(a)";
            String originalPath=string.Format(path+"\\"+Content.Text);
            var file = new StreamReader(originalPath); 
            var reader = new CsvReader(file);

            //CSVReader will now read the whole file into an enumerable
            IEnumerable<Student> records = reader.GetRecords<Student>();
            var studentinfo = new StudentDatabaseContext();
            foreach (Student record in records)
            {
                StudentDb student = new StudentDb() { Name = record.Name, Id = record.Id, Address = record.Address };
                studentinfo.StudentDbs.Add(student);

                studentinfo.SaveChanges();
                
            }
            

        }
    }
}
