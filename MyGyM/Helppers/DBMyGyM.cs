using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGyM.Helppers
{
    public class DBMyGyM
    {
        public static MyContext DB { get; } = new MyContext();
    }
}
