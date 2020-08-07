using MicroRabbit.Domain.Cor.Commands;
using MicroRabbit.Domain.Cor.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Cor.Bus {
  public interface IEventBus {
    Task SendCommand<T>(T command) where T: Command;
    void Publish<T>(T @event) where T : Event;
    void Subscribe<T, TH>()
      where T : Event
      where TH : IEventHandler<T>;
  }
}
