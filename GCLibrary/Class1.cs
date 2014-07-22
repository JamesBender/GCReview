using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public class CanBeSeen
    {
        public bool Foo()
        {
            var canNotBeSeen = new CanNotBeSeen();

            return true;
        }
    }
}
