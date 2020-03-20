using System;
using System.Collections.Generic;
using System.Text;

namespace gitDiff
{
    class Compare
    {
        //simple method to check if both files are the same
        public static Boolean compare(string textOne, string textTwo)
        {
            if (textOne == textTwo)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        
    }
}
