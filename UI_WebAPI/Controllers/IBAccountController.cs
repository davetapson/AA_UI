using AA.DataAccess;
using AA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Web.Http;
using System.Web.Http.Description;

namespace UI_WebAPI.Controllers
{
    public class IBAccountController : ApiController
    {
        // GET: api/IBAccount
        [ResponseType(typeof(AA.Services.Account))]
        public IHttpActionResult Get()
        {
            try
            {
                AccountRepository accountRepository = new AccountRepository();
                List<Account> accounts = accountRepository.Retrieve();

                return Ok(accounts);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // GET: api/IBAccount/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                AccountRepository accountRepository = new AccountRepository();
                Account account = accountRepository.Get(id);

                return Ok(account);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // GET: api/IBAccount/5
        public IHttpActionResult Get(string accountNumber)
        {
            try
            {
                AccountRepository accountRepository = new AccountRepository();
                Account account = accountRepository.Get(accountNumber);

                return Ok(account);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // POST: api/IBAccount
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/IBAccount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/IBAccount/5
        public void Delete(int id)
        {
        }
    }
}
