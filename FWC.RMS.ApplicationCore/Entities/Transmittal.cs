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
    public class Transmittal : BaseEntity<long>
    {
        public Transmittal()
        {
        }

        public DateTime TransmittalDate { get; set; }
        public int TransmittalTotalCount { get; set; }
        public decimal TransmittalTotal { get; set; }
        public string TransmittalStatus { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
