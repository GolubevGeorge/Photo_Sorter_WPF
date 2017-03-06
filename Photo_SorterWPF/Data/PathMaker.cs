using Photo_SorterWPF.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Photo_SorterWPF
{
    class PathMaker
    {
        StringBuilder sb = new StringBuilder();
        FolderCreater folderCreater = new FolderCreater();
        Dictionary<FileInfo, string> fullPath = new Dictionary<FileInfo, string>();

        public Dictionary<FileInfo, string> DateBuilder(Dictionary<FileInfo, string> dictionary)
        {
            try
            {
                foreach (var item in dictionary)
                {
                    sb.Clear();

                    String[] splitDate = item.Value.Split('.', ' ');
                    sb.Append(Photo.stPath + @"\" + splitDate[2]);
                    folderCreater.Create(sb.ToString());

                    //sb.Append(@"\" + splitDate[2] + "." + splitDate[1]); // Добавление папки с месяцем (Можно добавить 
                    //createFolder.FoldCreater(sb.ToString());             // перечисление с названиями месяцев)     

                    sb.Append(@"\" + "(" + splitDate[0] + "." + splitDate[1] + "." + splitDate[2] + ")");
                    folderCreater.Create(sb.ToString());

                    sb.Append(@"\" + item.Key);

                    fullPath.Add(item.Key, sb.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return fullPath;
        }
    }
}