using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class AccountTransferCommand : Command
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public AccountTransferCommand(int from, int to, decimal transfer)
        {
            From = from;
            To = to;
            Amount = transfer;
        }
    }
}
