using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Model;
using System.Web.Http.Description;
using Data;

namespace Web_app.Controllers
{
    public class AdminController : ApiController
    {

        // GET api/event

        [ResponseType(typeof(IEnumerable<DispalyData>))]
        public IHttpActionResult Get()
        {
            return Ok(Servis.DisplayAll());
        }

        // POST api/event
        [ResponseType(typeof(ModelData))]

        public IHttpActionResult Post(ModelData data)
        {
            if (data == null) { return Ok(Servis.DisplayAll()); }
            return Ok(Servis.SaveData(data.eventID, data.firstName, data.lastName, data.phoneNumber, data.roomNumber, data.email)); 
        }

    }
}