using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class FileTracer : IMyTracer
    {
        private string filename = "filename.txt";
        public void Trace(string msg)
        {
            File.WriteAllText(filename, msg);
    }
        }
}