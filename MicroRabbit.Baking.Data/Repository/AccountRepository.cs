using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Baking.Data.Repository {
  public class AccountRepository : IAccountRepository {
    private BankingDbContext _ctx;
    public AccountRepository(BankingDbContext ctx) {
      _ctx = ctx;
    }
    public IEnumerable<Account> GetAccounts() {
      return _ctx.Accounts;
    }
  }
}
