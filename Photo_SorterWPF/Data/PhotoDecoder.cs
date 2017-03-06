using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace Photo_SorterWPF
{
    class PhotoDecoder
    {
        List<string> listOfBadPhoto = new List<string>();
        List<string> listOfNoDatePhoto = new List<string>();
        Dictionary<FileInfo, string> photoInfoAndDate = new Dictionary<FileInfo, string>();

        public Dictionary<FileInfo, string> Decode(FileInfo[] photoCatalog)
        {
            if (photoCatalog == null)
            {
                throw new NullReferenceException("Empty reference in 'PhotoDecoder'");
            }
            else
            {
                foreach (var item in photoCatalog)
                {
                    try
                    {
                        using (FileStream stream = File.Open(item.FullName, FileMode.Open, FileAccess.ReadWrite))
                        {
                            BitmapDecoder bitmapDecoder = JpegBitmapDecoder.Create(stream, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
                            BitmapMetadata photoDate = (BitmapMetadata)bitmapDecoder.Frames[0].Metadata.Clone(); 

                            if (photoDate.DateTaken != null)
                            {
                                photoInfoAndDate.Add(item, photoDate.DateTaken);

                            }
                            else
                            {
                                listOfNoDatePhoto.Add(item.FullName); // Создать метод который отображает этот список
                            }
                        }
                    }
                    catch (Exception)
                    {
                        listOfBadPhoto.Add(item.FullName); // Создать метод который отображает этот список
                    }
                }
            }

            return photoInfoAndDate;
        }
    }
}