using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey reg;
            reg = Registry.CurrentUser.OpenSubKey("software", true);
            reg.CreateSubKey("newsubkey");
            Registry.CurrentUser.OpenSubKey(@"software\newsubkey", true);
            reg.SetValue("test", 1);
        }
    }
}
