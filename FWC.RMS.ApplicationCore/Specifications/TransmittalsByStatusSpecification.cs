using FWC.RMS.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Specifications
{

    public class TransmittalsByStatusSpecification : BaseSpecification<Transmittal>
    {
        

        public TransmittalsByStatusSpecification(string status) : base(x => x.TransmittalStatus == status)
        {
           
        }
    }
}
