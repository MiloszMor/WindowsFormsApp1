using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    internal class czas
    {
        private static DateTime odliczaj, skoncz;

        public double Zhonyi
        {
            get
            {
                if (odliczaj != default && skoncz != default)
                {
                    return (skoncz - odliczaj).TotalMilliseconds;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void odlicz()
        {
            odliczaj = DateTime.Now;
        }

        public static void stop()
        {
            skoncz = DateTime.Now;
        }
    }

}