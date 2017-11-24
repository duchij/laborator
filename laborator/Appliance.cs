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
    

   

}
