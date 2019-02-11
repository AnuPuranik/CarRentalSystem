using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystemDesignNew.View
{
    public class ErrorObject
    {
       public Boolean isValid{get;set;}
        public string ErrorMsg {get; set;}

        public ErrorObject(Boolean isValid, string ErrorMsg)
        {
            this.isValid = isValid;
            this.ErrorMsg = ErrorMsg;
        }

        public  Boolean GetIsValid()
        {
            return this.isValid;

        }

        public String GetErrorMsg()
        {
            return this.ErrorMsg;

        }
    }
}
