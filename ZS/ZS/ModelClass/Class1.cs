using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS.ModelClass
{
    class Class1
    {
        public bool IsNumber(string str)
        {
            foreach (char c in str)
            {
                if ( Char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
