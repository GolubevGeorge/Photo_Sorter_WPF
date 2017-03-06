using System;
using System.IO;

namespace Photo_SorterWPF
{
    class FolderCreater
    {
        public void Create(string path)
        {
            try
            {
                if (Directory.Exists(path)) // Определить, существует ли каталог
                {
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(path); // Попытка создания каталога
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

