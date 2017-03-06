using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Photo_SorterWPF.Data
{
    public class CurrentDirectory
    {
        public CurrentDirectory() { }

        public readonly string path;

        public CurrentDirectory(string path)
        {
            this.path = path;
        }
    }
}

//public string GetDirectory(string cd)
//{
//    try
//    {

//        //string cd = Directory.GetCurrentDirectory(); // Использует местоположение Photo_Sorter.exe файла
//        //string cd = @"C:\Users\Emris\Desktop\Test";   // Использует указанное вручную местоположение

//        return cd;
//    }
//    catch (Exception e)
//    {
//        throw e;
//    }
//}
