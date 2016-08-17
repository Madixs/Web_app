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
        // GET api/Admin

        [ResponseType(typeof(IEnumerable<DispalyData>))]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // POST api/Admin

        [ResponseType(typeof(ModelData))]
        public IHttpActionResult Post(ModelData data)
        {

            string name = data.firstName;
            string surname = data.lastName;
            string phoneNumber = data.phoneNumber;
            int room = data.roomNumber;
            int eventID = data.eventID;
            string email = data.email;
            return Ok(ServissResolver.Get().ServisSaveData(eventID, name, surname, phoneNumber, room, email)); 
            //return Ok(Servis.SaveData(eventID,name,surname,phoneNumber,room,email)); 
            //ServissResolver.Get().ServisSaveData(eventID, name, surname, phoneNumber, room, email)); 
        }

    }
}