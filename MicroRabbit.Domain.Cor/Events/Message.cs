using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MicroRabbit.Domain.Cor.Events {
  public abstract class Message : IRequest<bool> {
    public string MessageType { get; protected set; }
    protected Message() {
      MessageType = GetType().Name;
    }
  }
}
