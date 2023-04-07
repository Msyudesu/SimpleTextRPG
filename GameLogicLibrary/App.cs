using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary
{
    internal static class App
    {
        private static string appPath = System.Reflection.Assembly.GetEntryAssembly().Location;
        private static string appDir = Path.GetDirectoryName(appPath);

        internal static readonly string RootDirectory = appDir+ @"\";
    }
}
