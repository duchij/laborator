using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    static class Lab2
    {

        public static Appliance Init(string type)
        {
            switch (type)
            {
                case "microscope":
                    return new Microscope("microscope");
                case "centrifuge":
                    return new Centrifuge("centrifuge");
                default:
                    return null;
            }
        }

    }
}
