using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FWC.RMS.ApplicationCore.Interfaces;
using FWC.RMS.ApplicationCore.DTOs;

namespace FWC.RMS.Infrastructure.Data
{
   
    public class SearchRepository : ISearchRepository
    {
        protected readonly RMSDbContext _dbContext;

        public SearchRepository(RMSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public List<DepartmentDocumentSearchResponse> AdvancedSearch(DepartmentDocumentSearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentDocumentSearchResponse> BasicSearch(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
