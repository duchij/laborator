using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    sealed class Centrifuge : Appliance
    {

        string fnc;

        public Centrifuge(string fnc)
        {
            this.fnc = fnc;     
        }


        public override string GetDetailApplianceInfo()
        {
            return base.GetDetailApplianceInfo() + "- Centrifuge";
        }

        public void setAppNum(int num)
        {
            this.appNum = num;
        }

        public override string getApplFunction()
        {
            return "Centrifuge is " + this.fnc;
        }
    }
}
