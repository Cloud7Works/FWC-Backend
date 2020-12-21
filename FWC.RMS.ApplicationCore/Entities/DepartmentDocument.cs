/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using FWC.RMS.ApplicationCore.Data;

namespace FWC.RMS.ApplicationCore.Entities
{
    [Table("DepartmentDocument")]
    public class DepartmentDocument : BaseEntity<long>, IAuditable
    {
        public DepartmentDocument()
        {
        }

        public long CheckNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public Decimal CheckAmount { get; set; }
        public string CashListing { get; set; }
        public string Comments { get; set; }
        public long TransmittalNumber { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public Transmittal Transmittal { get; set; }

    }
}
