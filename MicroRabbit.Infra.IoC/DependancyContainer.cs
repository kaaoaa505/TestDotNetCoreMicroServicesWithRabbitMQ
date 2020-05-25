using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MircoRabbit.Banking.Application.Interfaces;
using MircoRabbit.Banking.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Services.
            services.AddTransient<IAccountService, AccountService>();

            // Data services.
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
