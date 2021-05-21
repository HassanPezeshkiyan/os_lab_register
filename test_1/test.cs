using.win32;
{
RegistryKey reg;
reg=Registry.LocalMachine.OpenSubKey("HardWare",true);
Console.WriteLine(reg.ValueCount().ToString());
}
