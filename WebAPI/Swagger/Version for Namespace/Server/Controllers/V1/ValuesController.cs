﻿using System.Web.Http;

namespace Server.Controllers.V1
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return this.Ok("我是地板");
        }
    }
}