using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeScammer.API
{
    public static class Kernel
    {
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
    }
}
