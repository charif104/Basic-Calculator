using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// holds information about single calculator operation
    /// </summary>
  public  class Operation
    {
        #region Public Properties
        public string LeftSide { get; set; }

        public string RightSide { get; set; }

        public OperatingTypes OperationTypes { get; set; }

        public Operation InnerOperation { get; set; }

        #endregion

        #region
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;  
        }
        #endregion
    }
}
