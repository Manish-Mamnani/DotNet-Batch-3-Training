using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOAIRSecurity
{
    public class EntryUtility
    {

        #region Properties

        public string EmployeeID {  get; set; }
        public string EntryType {  get; set; }
        public int Duration { get; set; }

        #endregion

        #region Methods

        public bool ValidateEmployeeID(string employeeID)
        {
            if(string.IsNullOrEmpty(employeeID))
            {
                throw new InvalidEntryException("Employee Id is either null or empty!");
            }
            else if(employeeID.Length != 10)
            {
                throw new InvalidEntryException("Employee Id should be of length 10");
            }
            else if((employeeID.Substring(0,5) != "GOAIR") || (employeeID[5] != '/') || !(employeeID.Substring(6, 4).All(char.IsDigit)))
            {
                throw new InvalidEntryException("Employee Id is invalid!");
            }
            else
            {
                return true;
            }

        }

        public bool ValidateDuration(int duration)
        {
            if(duration >= 1 && duration <= 5)
            {
                return true;
            }
            else
            {
                throw new InvalidEntryException("Duration is invalid!");
            }
        }

        #endregion

    }
}
