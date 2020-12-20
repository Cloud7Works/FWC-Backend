using FWC.RMS.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Interfaces
{
   public interface ITransmittalService
    {
        TransmittalDto CreateTransmittal(CreateTransmittalRequest transmittalRequest);

        TransmittalDto UpdateTransmittal(long transmittalId, UpdateTransmittalRequest transmittalRequest);

        List<TransmittalDto> GetTransmittalsByStatus(string transmittalStatus);
    }
}
