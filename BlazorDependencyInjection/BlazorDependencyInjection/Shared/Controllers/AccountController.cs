using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorDependencyInjection.Shared.Controllers
{
    
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private AccountDetails account = new AccountDetails
        {
            Name = "Checking Account",
            Balance = 12456.00,
            Transactions = new List<Transaction> {
                   new Transaction
                   {
                        Code = "ujtyhrgefd68tr7h67h4",
                        Amount = 50.00,
                        Name = "Ralph Warehouse"
                   },
                   new Transaction
                   {
                        Code = "5t6y4j65y4jh6df54hj68",
                        Amount = 10.00,
                        Name = "Food for the Hungry"
                   },
                   new Transaction
                   {
                        Code = "68tnc7y981ty41n8ctn",
                        Amount = 150.00,
                        Name = "H&M Clothes"
                   }


                }
        };
        [HttpGet("details")]
        public AccountDetails Details(string apikey)
        {
            if (apikey != "yhgtrfrghyjutyrtdhgr") {
                return new AccountDetails();
            }
            return account;
        }
        // POST api/<controller>
        [HttpPost("addtransaction")]
        public AccountDetails AddTransaction([FromBody]Transaction newTransaction)
        {
            account.Transactions.Add(newTransaction);
            account.Balance = account.Balance - newTransaction.Amount;
            return account;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
