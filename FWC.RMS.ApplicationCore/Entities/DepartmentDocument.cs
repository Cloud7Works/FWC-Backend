/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 */
using System;
using FWC.RMS.ApplicationCore.Data;

namespace FWC.RMS.ApplicationCore.Entities
{
    public class DepartmentDocument : BaseEntity<long>
    {
        public DepartmentDocument()
        {
        }

        public int CheckNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CheckAmount { get; set; }
        public string CashListing { get; set; }
        public string Comments { get; set; }
        public long TransmittalNumber { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
