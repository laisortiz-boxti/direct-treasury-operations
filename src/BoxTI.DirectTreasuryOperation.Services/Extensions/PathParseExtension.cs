using System;

namespace BoxTI.DirectTreasuryOperation.Services.Extensions
{
    public static class PathParseExtension
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                // Pasta User : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                /* Pasta C: */ : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%");

            return path.Replace("~", home);
        }
    }
}