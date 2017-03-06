using Photo_SorterWP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Photo_SorterWPF.Data
{
    class Extractor
    {
        public ObservableCollection<PhotoModel> Extract(string path)
        {
            try
            {
                Dictionary<FileInfo, string> photoInfoAndPath = new Dictionary<FileInfo, string>();

                FileInfo[] photoCatalog = new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories);

                foreach (var item in photoCatalog)
                {
                    photoInfoAndPath.Add(item, path + @"\"+ item.Name);

                }

                new Mover().Move(photoInfoAndPath);

                photoInfoAndPath.Clear();

                foreach (var item in photoCatalog)
                {
                    photoInfoAndPath.Add(item, item.LastWriteTime.ToString());
                }

                return new PhotoView().Show(photoInfoAndPath);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
