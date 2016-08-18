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
        // GET api/Admin/1

        [ResponseType(typeof(IEnumerable<DispalyData>))]
        public IHttpActionResult Get(string filter)
        {
            return Ok(ServissResolver.Get().ServisDisplayFilter(filter));
        }
        // GET api/Admin

        [ResponseType(typeof(IEnumerable<DispalyData>))]
        public IHttpActionResult Get()
        {
            return Ok(ServissResolver.Get().ServisDisplayAll());

        }
        // POST api/Admin

        [ResponseType(typeof(ModelData))]
        public IHttpActionResult Post(ModelData data)
        {
            return Ok(ServissResolver.Get().ServisSaveData(data.eventID, data.firstName, data.lastName, data.phoneNumber, data.roomNumber, data.email)); 
            //return Ok(Servis.SaveData(eventID,name,surname,phoneNumber,room,email)); 
            //ServissResolver.Get().ServisSaveData(eventID, name, surname, phoneNumber, room, email)); 
        }

    }
}