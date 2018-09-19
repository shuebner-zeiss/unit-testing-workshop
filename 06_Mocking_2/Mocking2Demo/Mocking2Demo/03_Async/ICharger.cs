using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mocking2Demo._03
{
    public interface ICharger
    {
        Task<Result> ChargeAsync(Customer debitor);
    }

    public enum Result
    {
        Error,
        Success,
    }
}
