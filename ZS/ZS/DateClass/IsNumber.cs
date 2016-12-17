using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS.DateClass
{
    class IsNumber
    {
        public bool isNumber(string str)
        { 
            foreach(char c in str)
            {
                if (c < 0 || c > 9)
                {
                    return false;
                }
            }
            return true;
        }

     //   public bool IsIdRepeat ()
    }
}
