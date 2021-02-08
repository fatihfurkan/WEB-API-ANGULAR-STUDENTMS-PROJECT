using SMS.Database.Model;
using SMS.Database.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SMS.API.Controllers
{
    public class RoleController : ApiController
    {
        RoleProcess roleProcess = new RoleProcess();
        [System.Web.Http.HttpGet]
        public List<ROLEType> GetRoles()
        {
            return roleProcess.GetRoles();
        }
    }
}