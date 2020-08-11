using MicroRabbit.Baking.Domain.Models;
using MicroRabbit.Banking.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Interfaces {
  public interface IAccountService {
    IEnumerable<Account> GetAccounts();
    void Transfer(AccountTransfer accountTransfer);
  }
}
