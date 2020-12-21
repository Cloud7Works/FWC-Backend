using AutoMapper;
using FWC.RMS.ApplicationCore.DTOs;
using FWC.RMS.ApplicationCore.Interfaces;
using System.Collections.Generic;

namespace FWC.RMS.ApplicationCore.Services
{
    public class DepartmentDocumentSearchService : IDepartmentDocumentSearchService
    {
        private readonly ISearchRepository _searchRepository;

        private readonly IMapper _mapper;

        public DepartmentDocumentSearchService(ISearchRepository searchRepository, IMapper mapper)
        {
            _searchRepository = searchRepository;
            _mapper = mapper;
        }

        public List<DepartmentDocumentSearchResponse> AdvancedSearch(DepartmentDocumentSearchRequest searchRequest)
        {
            return _searchRepository.AdvancedSearch(searchRequest);
        }

        public List<DepartmentDocumentSearchResponse> BasicSearch(string keyword)
        {

            return _searchRepository.BasicSearch(keyword);
        }
    }
}
