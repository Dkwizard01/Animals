using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class MyDebugWindowsTracer : IMyTracer
    {
        public void Trace(string msg)
        {
            Debug.WriteLine(msg);
        }
    }
}
