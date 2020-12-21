/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FWC.RMS.ApplicationCore.Data;

namespace FWC.RMS.ApplicationCore.Entities
{
    [Table("Transmittal")]
    public class Transmittal : BaseEntity<long>, IAuditable
    {
        public Transmittal()
        {
        }

        public DateTime TransmittalDate { get; set; }
        public int TransmittalTotalCount { get; set; }
        public decimal TransmittalTotal { get; set; }
        public string TransmittalStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public List<DepartmentDocument> DepartmentDocuments { get; set; }

    }
}
