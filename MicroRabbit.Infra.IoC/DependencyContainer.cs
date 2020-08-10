﻿using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Data.Repository;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
  public class DependencyContainer
  {
    public static void RegisterServices(IServiceCollection services) {
      // Domain Bus
      services.AddTransient<IEventBus, RabbitMQBus>();

      // Aplication Services
      services.AddTransient<IAccountService, AccountService>();

      // Data
      services.AddTransient<IAccountRepository, AccountRepository>();
      services.AddTransient<BankingDbContext>();
    }
  }
}
