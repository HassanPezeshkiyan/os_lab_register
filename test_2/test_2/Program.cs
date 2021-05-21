using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                RegistryKey reg;
                reg = Registry.CurrentUser.OpenSubKey(@"SoftWare\Microsoft\Windows\CurrentVersion\policies", true);
                reg.OpenSubKey("system");
                reg.SetValue("DisableRegistryTools", 1);
            }

        }
    }
}
