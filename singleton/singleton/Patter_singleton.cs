using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Patter_singleton
    {
        private static Patter_singleton instance;

        public static Patter_singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Patter_singleton();
                }
                return instance;
            }
        }
    }
}
