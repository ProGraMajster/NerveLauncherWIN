using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Provider;

namespace NerveLauncherWIN
{
    public static class ContentManager
    {
        public static string DownloadContentLink = "";

        public static string PathMain = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+ "//NerveLauncher//";
        public static string PathTemp = PathMain + "Temp//";
        public static string PathContent = PathMain + "Content//";
        public static void Init()
        {
            CheckDir(PathMain);
            CheckDir(PathContent);
            CheckDir(PathTemp);


        }

        static void CheckDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }
    }
}
