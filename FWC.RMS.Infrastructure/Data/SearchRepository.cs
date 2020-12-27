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

            var result = _dbContext.Transmittals
            .AsNoTracking()
            .Join(_dbContext.DepartmentDocuments, t => t.Id, d => d.TransmittalNumber,
            (t, d) => new { t, d })
            .Select(td => new DepartmentDocumentSearchResponse
            {
                TransmittalNumber = td.t.Id,
                TransmittalStatus = td.t.TransmittalStatus,
                DepartmentDocumentNumber = td.d.Id,
                FirstName = td.d.FirstName,
                LastName = td.d.LastName,
                CompanyName = td.d.CompanyName,
                CheckNumber = td.d.CheckNumber,
                CheckAmount = td.d.CheckAmount,
                CashListing = td.d.CashListing,
            });


            if (searchRequest.TransmittalNumber.HasValue)
                result = result.Where(td => td.TransmittalNumber == searchRequest.TransmittalNumber);

            if (searchRequest.DepartmentDocumentNumber.HasValue)
                result = result.Where(td => td.DepartmentDocumentNumber == searchRequest.DepartmentDocumentNumber);

            if (searchRequest.CheckNumber.HasValue)
                result = result.Where(td => td.CheckNumber == searchRequest.CheckNumber);

            if (!String.IsNullOrEmpty(searchRequest.TransmittalStatus))
                result = result.Where(td => td.TransmittalStatus == searchRequest.TransmittalStatus);

            if (!String.IsNullOrEmpty(searchRequest.FirstName))
                result = result.Where(td => EF.Functions.Like(td.FirstName, "%" + searchRequest.FirstName + "%"));

            if (!String.IsNullOrEmpty(searchRequest.LastName))
                result = result.Where(td => EF.Functions.Like(td.LastName, "%" + searchRequest.LastName + "%"));

            if (!String.IsNullOrEmpty(searchRequest.CompanyName))
                result = result.Where(td => EF.Functions.Like(td.CompanyName, "%" + searchRequest.CompanyName + "%"));

            return result.ToList();
        }

        public List<DepartmentDocumentSearchResponse> BasicSearch(string keyword)
        {
            var result = _dbContext.Transmittals
            .AsNoTracking()
           .Join(_dbContext.DepartmentDocuments, t => t.Id, d => d.TransmittalNumber,
           (t, d) => new { t, d })
                 .Where(td => td.d.TransmittalNumber.ToString() == keyword
                  || td.d.CheckNumber.ToString() == keyword
                  || td.d.Id.ToString() == keyword
                  || EF.Functions.Like(td.d.FirstName, "%" + keyword + "%")
                  || EF.Functions.Like(td.d.LastName, "%" + keyword + "%")
                  || EF.Functions.Like(td.d.CompanyName, "%" + keyword + "%")
                 
              )
           .Select(td => new DepartmentDocumentSearchResponse
           {
               TransmittalNumber = td.t.Id,
               TransmittalStatus = td.t.TransmittalStatus,
               DepartmentDocumentNumber = td.d.Id,
               FirstName = td.d.FirstName,
               LastName = td.d.LastName,
               CompanyName = td.d.CompanyName,
               CheckNumber = td.d.CheckNumber,
               CheckAmount = td.d.CheckAmount,
               CashListing = td.d.CashListing,
           });

            return result.ToList();
        }
    }
}
