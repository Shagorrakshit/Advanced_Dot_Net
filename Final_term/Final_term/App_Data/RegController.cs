using BLL.Bos;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_term.App_Data
{
    public class RegController : ApiController
    {
        [Route("api/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RegService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/user/create")]
        [HttpPost]
        public HttpResponseMessage Create(Reg st)
        {
            var data = RegService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }
    }
}
