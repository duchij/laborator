using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{

    public abstract class Appliance:IApplControl,IApplService
    {

        private int _appNum;

        public string repairStatus = "new";

        public int appNum
        {
            get { return this._appNum; }
            set { this._appNum = value; }
        }

        private bool _state;

        public bool state
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // public abstract int applianceNum();

        public abstract string getApplFunction();

        public virtual string GetDetailApplianceInfo()
        {
            return "Zakladny pristroj od neho odvodeny ";
        }

        public virtual void turnOn()
        {
            this.state = true;
        }

        public virtual void turnOff()
        {
            this.state = false;
        }

        public virtual void repair()
        {
            this.repairStatus = "repaired";
        }



    }


    sealed class Microscope : Appliance
    {

        string fnc;

        public Microscope(string fnc)
        {
            this.fnc = fnc;
        }



        public override string GetDetailApplianceInfo()
        {
            return base.GetDetailApplianceInfo()+"-Microscope";
        }

        public void setAppNum(int num)
        {
            this.appNum = num;
        }

        public override string getApplFunction()
        {
            return "Microscope is "+this.fnc;
        }

    }

    sealed class Centrifuge: Appliance
    {

        string fnc;

        public Centrifuge(string fnc)
        {
            this.fnc = fnc;
        }

      

        public override string GetDetailApplianceInfo()
        {
            return base.GetDetailApplianceInfo()+"- Centrifuge";
        }

        public void setAppNum(int num)
        {
            this.appNum = num;
        }

        public override string getApplFunction()
        {
            return "Centrifuge is "+this.fnc;
        }
    }

}
