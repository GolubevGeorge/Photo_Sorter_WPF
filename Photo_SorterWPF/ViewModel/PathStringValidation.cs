using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace Photo_SorterWPF.Data
{
    class PathStringValidation
    {
        public string Validate(string path)
        {
            try
            {
                if (path == String.Empty)
                {
                    MessageBox.Show("Please select the folder first!", "Photo Sorter");
                    return null;
                }
                else if (!Regex.IsMatch(path, @"^(?:[a-zA-Z]\:|\\\\[\w\\.]+\\[\w.$]+)\\(?:[\w\]+\\)*\w([\w.])+$"))
                {
                    MessageBox.Show("Please enter a valid path!", "Photo Sorter");
                    return null;
                }
                else if (!Directory.Exists(path))
                {
                    MessageBox.Show("Please enter an existing folder!", "Photo Sorter");
                    return null;
                }
                else
                {
                    return path;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}