using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzleChapter12
{
    class Kangaroo
    {
        FileStream fs;
        int croc;
        int dingo = 0;
        public int Wombat(int wallaby)
        {
            _______ __;
            try
            {
                if (wallaby > 0)
                {
                    fs = fs.OpenWrite("wobbiegong");
                    croc = 0;
                }
                else if (wallaby < 0)
                {
                    croc = 3;
                }
                else
                {
                    ___ = _____.OpenRead("wobbiegong");
                    croc = 1;
                }
            }
            catch (IOException)
            {
                croc = -3;
            }
            catch
            {
                croc = 4;
            }
            finally
            {
                if (______ > 2)
                {
                    croc ___ dingo;
                }
            }
            return ______;
        }
}
