using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    internal class FileNotFoundClass
    {
        public static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Admin\Downloads\NewFile.txt";
            try
            {
                //Check File exits
                if (!File.Exists(FilePath))
                {
                    throw new FileNotFoundException();
                }
                //Read file Contents
                string FileContents = File.ReadAllText(FilePath);
                Console.WriteLine("FileContents is Displayed:");
                Console.WriteLine(FileContents);
            } 
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
