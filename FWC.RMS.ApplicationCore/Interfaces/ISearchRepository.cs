using FWC.RMS.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FWC.RMS.ApplicationCore.Interfaces
{
    public interface ISearchRepository
    {
        List<DepartmentDocumentSearchResponse> AdvancedSearch(DepartmentDocumentSearchRequest searchRequest);

        List<DepartmentDocumentSearchResponse> BasicSearch(string keyword);
    }
}
