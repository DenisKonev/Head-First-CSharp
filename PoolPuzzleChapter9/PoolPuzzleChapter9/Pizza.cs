using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzleChapter9
{
    class Pizza
    {
        private StreamWriter writer;
        public Pizza(StreamWriter writer)
        {
            this.writer = writer;
        }
        public void Idaho(Pineapple.Fargo f)
        {
            writer.WriteLine(f);
            writer.Close();
        }
    }
}
