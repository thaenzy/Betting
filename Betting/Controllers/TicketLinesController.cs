using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Betting;
using Betting.ViewModels.Tickets;

namespace Betting.Controllers
{
    public partial class TicketLinesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: TicketLines
        public virtual ActionResult Index()
        {
            var ticketLines = db.TicketLine
                .Where(tl => !tl.IsDeleted)
                .Include(t => t.BetType)
                .Include(t => t.Player)
                .Include(t => t.Result)
                .Include(t => t.Ticket)
                .ToList();
            return View(ticketLines);
        }

        // GET: TicketLines/Details/5
        public virtual ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketLine ticketLine = db.TicketLine.Find(id);
            if (ticketLine == null)
            {
                return HttpNotFound();
            }
            return View(ticketLine);
        }

        // GET: TicketLines/Create
        public virtual ActionResult Create(int ticketId)
        {
            ViewBag.BetTypeId = new SelectList(db.BetType, "Id", "Name");
            ViewBag.PlayerId = new SelectList(db.Player, "Id", "Name");
            ViewBag.ResultId = new SelectList(db.Result, "Id", "Name");
            ViewBag.TicketId = ticketId;
            return View();
        }

        // POST: TicketLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create([Bind(Include = "Id,TicketId,ResultId,PlayerId,BetTypeId,Odd,IsDeleted,Game")] TicketLine ticketLine)
        {
            if (ModelState.IsValid)
            {
                db.TicketLine.Add(ticketLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BetTypeId = new SelectList(db.BetType, "Id", "Name", ticketLine.BetTypeId);
            ViewBag.PlayerId = new SelectList(db.Player, "Id", "Name", ticketLine.PlayerId);
            ViewBag.ResultId = new SelectList(db.Result, "Id", "Name", ticketLine.ResultId);
            ViewBag.TicketId = new SelectList(db.Ticket, "Id", "CreatedBy", ticketLine.TicketId);
            return View(ticketLine);
        }

        // GET: TicketLines/Edit/5
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketLine ticketLine = db.TicketLine.Find(id);
            if (ticketLine == null)
            {
                return HttpNotFound();
            }
            var viewModel = new EditTicketLineViewModel();
            viewModel.TicketLine = new TicketLineViewModel(ticketLine);
            viewModel.BetTypes = new SelectList(db.BetType, "Id", "Name");//, ticketLine.BetTypeId);
            viewModel.Players = new SelectList(db.Player, "Id", "Name");//, ticketLine.PlayerId);
            viewModel.Results = new SelectList(db.Result, "Id", "Name");//, ticketLine.ResultId);
            return View(viewModel);
        }

        // POST: TicketLines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(EditTicketLineViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                db.Entry(viewModel.TicketLine.TicketLine).State = EntityState.Modified;
                var parts = viewModel.TicketLine.TicketTime.Split(':');
                var timespan = new TimeSpan(int.Parse(parts[0]), int.Parse(parts[1]), 0);
                viewModel.TicketLine.TicketLine.GamePlayedOn = viewModel.TicketLine.TicketLine.GamePlayedOn.Value.Date + timespan;
                db.SaveChanges();
                return RedirectToAction(MVC.Tickets.Details(viewModel.TicketLine.TicketLine.TicketId));
            }
            
            return View(viewModel);
        }

        // GET: TicketLines/Delete/5
        public virtual ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketLine ticketLine = db.TicketLine.Find(id);
            if (ticketLine == null)
            {
                return HttpNotFound();
            }
            return View(ticketLine);
        }

        // POST: TicketLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            TicketLine ticketLine = db.TicketLine.Find(id);
            db.TicketLine.Remove(ticketLine);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
