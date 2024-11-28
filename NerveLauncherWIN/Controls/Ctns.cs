using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerveLauncherWIN.Controls
{
    public class Ctns
    {
        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            try
            {
                if (c != null)
                {
                    Type typeTB = typeof(Control);
                    System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    if (misSetStyle != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return retval;
        }
    }
}
