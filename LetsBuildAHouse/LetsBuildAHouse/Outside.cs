using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    class Outside : Location
    {
        private bool hot;
        public Outside(string name, bool hot) 
        : base(name)
        { this.hot = hot; }
        public override string Description
        {
            get 
            {
                string newDescription = base.Description;
                if (hot)
                    return newDescription += " It's very hot here.";
                else
                    return newDescription;
            }
        }
    }
}
