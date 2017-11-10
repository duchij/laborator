using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator
{
    partial class Laboratory
    {
        public Laboratory()
        {

        }

        public class Chief
        {
            private string firstName;
            private string lastName;

            public Chief( string lastName, string firstName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public string getFullName()
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }

            public void setFullName(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
        }

        public void startExamination()
        {
            
        }
        

        
    }
}
