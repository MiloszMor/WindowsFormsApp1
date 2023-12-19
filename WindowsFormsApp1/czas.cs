using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalek
{
    internal class czas
    {
        private static DateTime start, stop;
        public Double Duration
        {
            get
            {
                if (start != null && stop != null)
                {
                    return (stop - start).TotalMilliseconds;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void StartCount()
        {
            start = DateTime.Now;
        }

        public static void StopCount()
        {
            stop = DateTime.Now;
        }
    }
}