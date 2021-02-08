using SMS.Database.Model;
using SMS.Database.Process;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace SMS.API.Controllers
{
    public class UserController : ApiController
    {
        UserProcess studentProcess = new UserProcess();
        [System.Web.Http.HttpGet]
        public List<USERType> GetUser()
        {
            return studentProcess.GetUserAll();
        }
        [System.Web.Http.HttpGet]
        public List<GetUserInfo_Result> GetUserByEmail(string email, string password)
        {
            return studentProcess.GetUserByEmail(email, password);
        }

        [System.Web.Http.HttpPost]
        public HttpResponseMessage InsertUser(USER userRecord)
        {
            if (userRecord == null)
            {
                return null;
            }
            else if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            try
            {
                userRecord.ID = Guid.NewGuid();
                userRecord.CREATIONDATE = DateTime.Now;
                studentProcess.InsertUser(userRecord);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Request.CreateResponse(HttpStatusCode.Created, userRecord); ;
        }
    }
}