sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey reg;
            reg = Registry.CurrentUser.OpenSubKey("Software", true);

            string[] fileName = reg.GetSubKeyNames();
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(fileName[i]);
                i++;
                Console.ReadKey();

            }
        }
    }
}
