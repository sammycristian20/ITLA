using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.Web.Mvc;
using ITLA_PE_MVC;
using ITLA_PE_MVC.SERVICE;
using ITLA_PE_MVC.ENTITY.MODELS;
using ITLA_PE_MVC.Models;
using ITLA_PE_MVC.ENTITY;

namespace ITLA_PE_MVC.Controllers
{
    public class SolicitudsController : ApiController
    {
        //private ORBIPEEntities db = new ORBIPEEntities();

        ServicesRequest serv = new ServicesRequest();
        // GET: api/Solicituds
        public IHttpActionResult GetSolicitud()
        {
            var solicitud = serv.SolicitudList();
            return Ok(new { results = solicitud });
        }

        // GET: api/Solicituds/5
        [ResponseType(typeof(ModelSolicituds))]
        public IHttpActionResult GetSolicitud(int id)
        {
            ModelSolicituds solicitud = serv.SolicitudGet(id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return Ok(solicitud);
        }

        // PUT: api/Solicituds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSolicitud(int id, Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != solicitud.SolicitudID)
            {
                return BadRequest();
            }

            //db.Entry(solicitud).State = EntityState.Modified;

            
            
            try
            {
                //serv.SolicitudUpdate(solicitud);
                //db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitudExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //// POST: api/Solicituds
        //[ResponseType(typeof(Solicitud))]
        //public IHttpActionResult PostSolicitud(Solicitud solicitud)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    //db.Solicitud.Add(solicitud);
        //    //db.SaveChanges();
        //    serv.SolicitudAdd(solicitud);

        //    return CreatedAtRoute("DefaultApi", new { id = solicitud.SolicitudID }, solicitud);
        //}

        // DELETE: api/Solicituds/5
        //[ResponseType(typeof(Solicitud))]
        //public IHttpActionResult DeleteSolicitud(int id)
        //{
        //    Solicitud solicitud = db.Solicitud.Find(id);
        //    if (solicitud == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Solicitud.Remove(solicitud);
        //    db.SaveChanges();

        //    return Ok(solicitud);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private bool SolicitudExists(int id)
        {
            return (serv.SolicitudGet(id) != null);
        }
    }
}