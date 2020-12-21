using FWC.RMS.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Interfaces
{
   public interface IDepartmentDocumentService
    {
        DepartmentDocumentDto CreateDepartmentDocument(long transmittalNumber, DepartmentDocumentRequest departmentDocumentRequest);

        DepartmentDocumentDto UpdateDepartmentDocument(long departmentDocumentNumber, DepartmentDocumentRequest departmentDocumentRequest);

        List<DepartmentDocumentDto> GetDepartmentDocumentsByTransmittalNumber(long transmittalNumber);
    }
}
