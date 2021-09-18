using System;
using System.IO;

namespace MyTestAPp
{
    public class NumberCompare
    {

        public bool GreaterThanZero(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new
                    ArgumentNullException("fileName");
            }
            return Int64.Parse(number) > 0;
        }
    }
}
