using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Photo_SorterWPF.View
{
    class FilesInFolder
    {
        public Task<string> CountAsync(string path)
        {
            try
            {
                if (Directory.Exists(path) & path != String.Empty & Regex.IsMatch(path, @"^(?:[a-zA-Z]\:|\\\\[\w\\.]+\\[\w.$]+)\\(?:[\w\]+\\)*\w([\w.])+$"))
                {
                    return Task.Run(() => new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories).Length.ToString());
                }

                return Task.Run(() => { return "--"; });

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}