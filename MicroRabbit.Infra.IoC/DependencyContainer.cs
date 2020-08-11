using MediatR;
using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Data.Repository;
using MicroRabbit.Baking.Domain.CommandHandlers;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Events;
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

      // Domain Banking Commands
      services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

      // Aplication Services
      services.AddTransient<IAccountService, AccountService>();

      // Data
      services.AddTransient<IAccountRepository, AccountRepository>();
      services.AddTransient<BankingDbContext>();
    }
  }
}
