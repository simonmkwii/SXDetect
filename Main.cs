using System.IO;

namespace SXDetect
{
    public static class Detect
    {
        public static bool IsUserRunningSXOS()
        {
            var FoundSXOS = false;
            foreach (var Drive in DriveInfo.GetDrives())
                if (File.Exists($"{Drive.RootDirectory}/boot.dat"))
                    FoundSXOS = true;
            return FoundSXOS;
        }
    }
}