using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mocking2HandsOn._02
{
    public interface ICharger
    {
        /// <exception cref="ChargingFailedException" />
        Task ChargeAsync(Customer debitor);
    }

    public class ChargingFailedException : Exception
    {
    }
}
