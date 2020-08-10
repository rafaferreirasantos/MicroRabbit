using MicroRabbit.Baking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Baking.Domain.Interfaces {
  public interface IAccountRepository {
    IEnumerable<Account> GetAccounts();
  }
}
