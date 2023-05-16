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
using WsApiexamen.Models;

namespace WsApiexamen.Controllers
{
    public class tblExamenController : ApiController
    {
        private BdiExamenEntities db = new BdiExamenEntities();

        // GET: api/tblExamen
        public IQueryable<tblExamen> GettblExamen()
        {
            return db.tblExamen;
        }

        // GET: api/tblExamen/5
        [ResponseType(typeof(tblExamen))]
        public IHttpActionResult GettblExamen(int id)
        {
            tblExamen tblExamen = db.tblExamen.Find(id);
            if (tblExamen == null)
            {
                return NotFound();
            }

            return Ok(tblExamen);
        }

        // PUT: api/tblExamen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblExamen(int id, tblExamen tblExamen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblExamen.idExamen)
            {
                return BadRequest();
            }

            db.Entry(tblExamen).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblExamenExists(id))
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

        // POST: api/tblExamen
        [ResponseType(typeof(tblExamen))]
        public IHttpActionResult PosttblExamen(tblExamen tblExamen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblExamen.Add(tblExamen);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblExamen.idExamen }, tblExamen);
        }

        // DELETE: api/tblExamen/5
        [ResponseType(typeof(tblExamen))]
        public IHttpActionResult DeletetblExamen(int id)
        {
            tblExamen tblExamen = db.tblExamen.Find(id);
            if (tblExamen == null)
            {
                return NotFound();
            }

            db.tblExamen.Remove(tblExamen);
            db.SaveChanges();

            return Ok(tblExamen);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblExamenExists(int id)
        {
            return db.tblExamen.Count(e => e.idExamen == id) > 0;
        }
    }
}