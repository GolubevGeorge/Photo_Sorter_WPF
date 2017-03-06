using System;
using System.Collections.Generic;
using System.IO;

namespace Photo_SorterWPF
{
    class Mover
    {
        public void Move(Dictionary<FileInfo, string> fullPath)
        {
            try
            {
                foreach (var item in fullPath)
                {
                    item.Key.MoveTo(item.Value);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}