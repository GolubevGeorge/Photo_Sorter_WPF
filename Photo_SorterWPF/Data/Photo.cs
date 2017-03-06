using Photo_SorterWP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Photo_SorterWPF.Data
{
    class Photo
    {
        public static string stPath;

        public Photo(string path)
        {
            stPath = path;
        }

        public ObservableCollection<PhotoModel> Sort()
        {
            try
            {
                FileInfo[] photoCatalog = new DirectoryInfo(Photo.stPath).GetFiles("*.jpg", SearchOption.AllDirectories);

                Dictionary<FileInfo, String> photoInfoAndDate = new PhotoDecoder().Decode(photoCatalog);

                Dictionary<FileInfo, String> photoInfoAndPath = new PathMaker().DateBuilder(photoInfoAndDate);

                new Mover().Move(photoInfoAndPath);

                return new PhotoView().Show(photoInfoAndDate);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
