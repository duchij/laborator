using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    


    partial class Laboratory 
    {

        private Appliance _app1;
        private Appliance _app2;

        public Appliance app1
        {
            get { return this._app1; }
            set { this._app1 = value; }
        }

        public Appliance app2
        {
            get;set;
        }
        
        

    }
}
