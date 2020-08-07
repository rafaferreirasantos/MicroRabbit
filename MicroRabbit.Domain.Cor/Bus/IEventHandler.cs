using MicroRabbit.Domain.Cor.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Cor.Bus {
  public interface IEventHandler<in TEvent> : IEventHandler
    where TEvent : Event {
    Task Handle(TEvent @event);
  }

  public interface IEventHandler { }
}
