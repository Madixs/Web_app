using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Model;
using System.Web.Http.Description;
using Resolvers;
using Service;

namespace Web_app.Controllers
{
    public class pokojeController : ApiController
    {
        // GET: pokoje
        [System.Web.Http.HttpGet]
        public List<RoomEmpty> pokoje()
        {
            return ServissResolver.Get().ServisRoomEmpty();
        }

    }
}