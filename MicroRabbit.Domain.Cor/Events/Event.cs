using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Cor.Events {
  public abstract class Event {
    public DateTime Timestamp { get; protected set; }
    protected Event() {
      Timestamp = DateTime.Now;
    }
  }
}
