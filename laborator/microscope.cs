using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    sealed class Microscope : Appliance
    {

        string fnc;

        public Microscope(string fnc)
        {
            this.fnc = fnc;
        }



        public override string GetDetailApplianceInfo()
        {
            return base.GetDetailApplianceInfo() + "-Microscope";
        }

        public void setAppNum(int num)
        {
            this.appNum = num;
        }

        public override string getApplFunction()
        {
            return "Microscope is " + this.fnc;
        }

    }
}
