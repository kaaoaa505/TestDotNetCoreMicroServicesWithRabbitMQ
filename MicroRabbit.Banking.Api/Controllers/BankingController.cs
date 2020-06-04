using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MircoRabbit.Banking.Application.Interfaces;
using MircoRabbit.Banking.Application.Models;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult TransferFunds([FromBody] AccountTransferRequest request)
        {
            _accountService.Transfer(request);
            return Ok();
        }
    }
}
