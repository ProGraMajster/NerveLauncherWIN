using NerveLauncher.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using Windows.Storage.Provider;

namespace NerveLauncherWIN
{
    public static class ContentManager
    {
        public static string DownloadContentLink = "";

        public static string PathMain = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+ "\\NerveLauncher\\";
        public static string PathTemp = PathMain + "Temp\\";
        public static string PathContent = PathMain + "Content\\";

        public static InstalledPackage InstalledPackage;
        public static void Init()
        {
            CheckDir(PathMain);
            CheckDir(PathContent);
            CheckDir(PathTemp);
            if(!File.Exists(PathContent + "installedPackage.json"))
            {
                CreateFileInstaledPackage(); 
            }
            else
            {
                LoadInfoInstalledPackage();
            }
        }

        static void CheckDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }

        static void LoadInfoInstalledPackage()
        {
            try
            {
                string json = File.ReadAllText(PathContent + "installedPackage.json");
                InstalledPackage = JsonSerializer.Deserialize<InstalledPackage>(json, new JsonSerializerOptions() { WriteIndented = true });
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        static void CreateFileInstaledPackage()
        {
            try
            {
                InstalledPackage installedPackage = new InstalledPackage();
                installedPackage.Packages = new List<NervePackage>();
                InstalledPackage = installedPackage;
                string json = JsonSerializer.Serialize(installedPackage, typeof(InstalledPackage), new JsonSerializerOptions() { WriteIndented = true });
                File.WriteAllText(PathContent+ "installedPackage.json", json);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        

        public static void UninstallFIP(string id)
        {
            if (InstalledPackage == null)
            {
                return;
            }
            if (InstalledPackage.Packages == null)
            {
                InstalledPackage.Packages = new List<NervePackage>();
            }

            var item = InstalledPackage.Packages.FirstOrDefault(x => x.PackageIdentifier == id);
            if (item == null)
            {
                return;
            }

            InstalledPackage.Packages.Remove(item);

            string json = JsonSerializer.Serialize(InstalledPackage, typeof(InstalledPackage), new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(PathContent + "installedPackage.json", json);
        }

        public static void UpdateFIP(string id, NerveLauncher.Data.NervePackage nervePackage)
        {
            if (InstalledPackage == null)
            {
                return;
            }
            if (InstalledPackage.Packages == null)
            {
                InstalledPackage.Packages = new List<NervePackage>();
            }

            var item = InstalledPackage.Packages.FirstOrDefault(x => x.PackageIdentifier == id);
            if (item == null)
            {
                return;
            }
            int index = InstalledPackage.Packages.IndexOf(item);
            if (index != -1)
                InstalledPackage.Packages[index] = nervePackage;

            string json = JsonSerializer.Serialize(InstalledPackage, typeof(InstalledPackage), new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(PathContent + "installedPackage.json", json);
        }

        public static void AddToFIP(NerveLauncher.Data.NervePackage nervePackage)
        {
            try
            {
                if(InstalledPackage == null)
                {
                    return;
                }
                if(InstalledPackage.Packages == null)
                {
                    InstalledPackage.Packages = new List<NervePackage>();
                }
                if (InstalledPackage.Packages.Contains(nervePackage))
                {
                    return;
                }
                InstalledPackage.Packages.Add(nervePackage);
                string json = JsonSerializer.Serialize(InstalledPackage, typeof(InstalledPackage), new JsonSerializerOptions() { WriteIndented = true });
                File.WriteAllText(PathContent + "installedPackage.json", json);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public async static Task<NerveLauncher.Data.NervePackage> GetNervePackage(string PackageIdentifier)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync($"https://raw.githubusercontent.com/ProGraMajster/NerveLauncher.DataContent/refs/heads/master/NerveLauncher.DataContent/PackageList/{PackageIdentifier}.json");
                    response.EnsureSuccessStatusCode();
                    var html = await response.Content.ReadAsStringAsync();

                    var r = Newtonsoft.Json.JsonConvert.DeserializeObject<NervePackage>(html);

                    return r;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }
    }
}
