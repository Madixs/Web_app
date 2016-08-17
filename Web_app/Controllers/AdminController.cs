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
    public class AdminController : ApiController
    {
        

        // GET api/event

        [ResponseType(typeof(IEnumerable<DispalyData>))]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // POST api/event

        [ResponseType(typeof(ModelData))]
        public IHttpActionResult Post(ModelData data)
        {
            int? eventID = data.eventID;
            string name = data.firstName;
            string surname = data.lastName;
            string phoneNumber = data.phoneNumber;
            int? room = data.roomNumber;
            string email = data.email;


      return Ok(); 
            //return Ok(Servis.SaveData(eventID,name,surname,phoneNumber,room,email)); 
        }

    }
}