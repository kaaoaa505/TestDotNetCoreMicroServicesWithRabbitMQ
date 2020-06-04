using MicroRabbit.Banking.Domain.Models;
using MircoRabbit.Banking.Application.Models;
using System.Collections.Generic;

namespace MircoRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransferRequest accountTransfer);
    }
}
