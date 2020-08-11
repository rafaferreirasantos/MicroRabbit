using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TransferController : ControllerBase
  {
    ITransferService _transferService;
    public TransferController(ITransferService trasferService)
    {
      _transferService = trasferService;
    }
   [HttpGet]
   public ActionResult<IEnumerable<TransferLog>> Get()
    {
      return Ok(_transferService.GetTransferLogs());
    }
  }
}
