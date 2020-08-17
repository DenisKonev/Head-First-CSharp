using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPuzzleChapter7
{
    class Picasso : INose
    {
        public Picasso(string face) { this.face = face; }
        public virtual int Ear() { return 7; }
        public virtual string Face { get { return face; } }
        private string face;
    }
}
