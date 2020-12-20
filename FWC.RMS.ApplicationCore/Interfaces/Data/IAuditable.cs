using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Data
{
    public interface IAuditable
    {
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }

    }
}
