using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class SSSsingleton
    {
        private static SSSsingleton instance;

        public static SSSsingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SSSsingleton();
                }
                return instance;
            }
        }
    }
}
