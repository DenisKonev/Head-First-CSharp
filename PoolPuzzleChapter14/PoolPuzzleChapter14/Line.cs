using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzleChapter14
{
    class Line
    {
        public string[] Words;
        public int Value;
        public Line(string[] Words, int Value)
        {
            this.Words = Words; this.Value = Value;
        }
    }
}
