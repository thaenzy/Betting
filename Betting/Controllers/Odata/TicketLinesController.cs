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
    builder.EntitySet<TicketLine>("TicketLines");
    builder.EntitySet<BetType>("BetType"); 
    builder.EntitySet<Player>("Player"); 
    builder.EntitySet<Result>("Result"); 
    builder.EntitySet<Ticket>("Ticket"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TicketLinesController : ODataController
    {
        private DataModel db = new DataModel();

        // GET: odata/TicketLines
        [EnableQuery]
        public IQueryable<TicketLine> GetTicketLines()
        {
            return db.TicketLine;
        }

        // GET: odata/TicketLines(5)
        [EnableQuery]
        public SingleResult<TicketLine> GetTicketLine([FromODataUri] int key)
        {
            return SingleResult.Create(db.TicketLine.Where(ticketLine => ticketLine.Id == key));
        }

        // PUT: odata/TicketLines(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<TicketLine> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TicketLine ticketLine = db.TicketLine.Find(key);
            if (ticketLine == null)
            {
                return NotFound();
            }

            patch.Put(ticketLine);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketLineExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ticketLine);
        }

        // POST: odata/TicketLines
        public IHttpActionResult Post(TicketLine ticketLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TicketLine.Add(ticketLine);
            db.SaveChanges();

            return Created(ticketLine);
        }

        // PATCH: odata/TicketLines(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<TicketLine> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TicketLine ticketLine = db.TicketLine.Find(key);
            if (ticketLine == null)
            {
                return NotFound();
            }

            patch.Patch(ticketLine);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketLineExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(ticketLine);
        }

        // DELETE: odata/TicketLines(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            TicketLine ticketLine = db.TicketLine.Find(key);
            if (ticketLine == null)
            {
                return NotFound();
            }

            db.TicketLine.Remove(ticketLine);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/TicketLines(5)/BetType
        [EnableQuery]
        public SingleResult<BetType> GetBetType([FromODataUri] int key)
        {
            return SingleResult.Create(db.TicketLine.Where(m => m.Id == key).Select(m => m.BetType));
        }

        // GET: odata/TicketLines(5)/Player
        [EnableQuery]
        public SingleResult<Player> GetPlayer([FromODataUri] int key)
        {
            return SingleResult.Create(db.TicketLine.Where(m => m.Id == key).Select(m => m.Player));
        }

        // GET: odata/TicketLines(5)/Result
        [EnableQuery]
        public SingleResult<Result> GetResult([FromODataUri] int key)
        {
            return SingleResult.Create(db.TicketLine.Where(m => m.Id == key).Select(m => m.Result));
        }

        // GET: odata/TicketLines(5)/Ticket
        [EnableQuery]
        public SingleResult<Ticket> GetTicket([FromODataUri] int key)
        {
            return SingleResult.Create(db.TicketLine.Where(m => m.Id == key).Select(m => m.Ticket));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TicketLineExists(int key)
        {
            return db.TicketLine.Count(e => e.Id == key) > 0;
        }
    }
}
