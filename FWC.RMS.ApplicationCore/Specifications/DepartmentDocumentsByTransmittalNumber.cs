using FWC.RMS.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Specifications
{

    public class DepartmentDocumentsByTransmittalNumberSpecification : BaseSpecification<DepartmentDocument>
    {
        

        public DepartmentDocumentsByTransmittalNumberSpecification(long transmittalNumber) : base(x => x.TransmittalNumber == transmittalNumber)
        {
           
        }
    }
}
