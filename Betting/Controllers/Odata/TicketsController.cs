using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using Betting;

namespace Betting.Controllers.Odata
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Betting;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Ticket>("Tickets");
    builder.EntitySet<TicketLine>("TicketLine"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TicketsController : ODataController
    {
        private DataModel db = new DataModel();

        // GET: odata/Tickets
        [EnableQuery]
        public IQueryable<Ticket> GetTickets()
        {
            return db.Ticket;
        }

        // GET: odata/Tickets(5)
        [EnableQuery]
        public SingleResult<Ticket> GetTicket([FromODataUri] int key)
        {
            return SingleResult.Create(db.Ticket.Where(ticket => ticket.Id == key));
        }

        // PUT: odata/Tickets(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Ticket> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ticket ticket = db.Ticket.Find(key);
            if (ticket == null)
            {
                return NotFound();
            }

            patch.Put(ticket);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ticket);
        }

        // POST: odata/Tickets
        public IHttpActionResult Post(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ticket.Add(ticket);
            db.SaveChanges();

            return Created(ticket);
        }

        // PATCH: odata/Tickets(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Ticket> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ticket ticket = db.Ticket.Find(key);
            if (ticket == null)
            {
                return NotFound();
            }

            patch.Patch(ticket);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ticket);
        }

        // DELETE: odata/Tickets(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Ticket ticket = db.Ticket.Find(key);
            if (ticket == null)
            {
                return NotFound();
            }

            db.Ticket.Remove(ticket);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Tickets(5)/TicketLine
        [EnableQuery]
        public IQueryable<TicketLine> GetTicketLine([FromODataUri] int key)
        {
            return db.Ticket.Where(m => m.Id == key).SelectMany(m => m.TicketLine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TicketExists(int key)
        {
            return db.Ticket.Count(e => e.Id == key) > 0;
        }
    }
}
