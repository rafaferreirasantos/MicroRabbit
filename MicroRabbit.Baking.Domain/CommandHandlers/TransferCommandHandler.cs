using MediatR;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Baking.Domain.CommandHandlers
{
  public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
  {
    private readonly IEventBus _bus;
    public TransferCommandHandler(IEventBus bus)
    {
      _bus = bus;
    }

    public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
    {
      //public event to RabbitMQ
      _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Ammount));
      return Task.FromResult(true);
    }
  }
}
