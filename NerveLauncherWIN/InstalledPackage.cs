using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NerveLauncherWIN
{
    [Serializable]
    public class InstalledPackage
    {
        public List<NerveLauncher.Data.NervePackage> Packages { get; set; }
    }
}
