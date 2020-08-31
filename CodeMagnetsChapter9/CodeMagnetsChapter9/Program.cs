using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagnetsChapter9
{
    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }
}
