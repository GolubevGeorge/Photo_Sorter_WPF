using Photo_SorterWP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Photo_SorterWPF
{
    class PhotoView
    {
        ObservableCollection<PhotoModel> photoName = new ObservableCollection<PhotoModel>();

        public ObservableCollection<PhotoModel> Show(Dictionary<FileInfo, String> photoInfoAndDate)
        {
            foreach (var item in photoInfoAndDate)
            {
                photoName.Add(new PhotoModel(item.Key.Name, item.Key.DirectoryName, item.Value, item.Key.CreationTime.ToString(), String.Format("{0:F}", item.Key.Length /1048576f), item.Key.Extension));
            }

            return photoName;
        }
    }
}
