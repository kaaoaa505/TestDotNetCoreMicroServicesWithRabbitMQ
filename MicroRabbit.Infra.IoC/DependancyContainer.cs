using MediatR;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MircoRabbit.Banking.Application.Interfaces;
using MircoRabbit.Banking.Application.Services;

namespace MicroRabbit.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            services.TryAddTransient<IRequestHandler<AccountTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            //services.TryAddTransient<IAccountService, AccountService>();
            services.TryAddTransient<ITransferService, TransferService>();

            //Data
            //services.TryAddScoped<BankingDbContext>();
            services.TryAddScoped<TransferDbContext>();
            //services.TryAddTransient<IAccountRepository, AccountRepository>();
            services.TryAddTransient<ITransferRepository, TransferRepository>();
        }
    }
}
