using FWC.RMS.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Interfaces
{
   public interface IDepartmentDocumentSearchService
    {
        List<DepartmentDocumentSearchResponse> AdvancedSearch(DepartmentDocumentSearchRequest searchRequest);

        List<DepartmentDocumentSearchResponse> BasicSearch(string keyword);
     
    }
}
