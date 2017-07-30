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
            var viewModel = new EditTicketLineViewModel(new TicketLine() { TicketId = ticketId });
            viewModel.BetTypes = new SelectList(db.BetType, "Id", "Name");
            viewModel.Players = new SelectList(db.Player, "Id", "Name");
            viewModel.Results = new SelectList(db.Result, "Id", "Name");
            return View(viewModel);
        }

        // POST: TicketLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(EditTicketLineViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SetGamePlayedOn(viewModel.TicketLine);
                db.TicketLine.Add(viewModel.TicketLine);
                db.SaveChanges();
                return RedirectToAction(MVC.Tickets.Details(viewModel.TicketLine.TicketId));
            }

            viewModel.BetTypes = new SelectList(db.BetType, "Id", "Name");
            viewModel.Players = new SelectList(db.Player, "Id", "Name");
            viewModel.Results = new SelectList(db.Result, "Id", "Name");
            return View(viewModel);
        }

        // GET: TicketLines/Edit/5
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketLine ticketLine = db.TicketLine.Find(id);
            SetGamePlayedOnTime(ticketLine);
            if (ticketLine == null)
            {
                return HttpNotFound();
            }
            var viewModel = new EditTicketLineViewModel(ticketLine);
            viewModel.BetTypes = new SelectList(db.BetType, "Id", "Name");//, ticketLine.BetTypeId);
            viewModel.Players = new SelectList(db.Player, "Id", "Name");//, ticketLine.PlayerId);
            viewModel.Results = new SelectList(db.Result, "Id", "Name");//, ticketLine.ResultId);
            return View(viewModel);
        }

        private void SetGamePlayedOnTime(TicketLine ticketLine)
        {
            ticketLine.GamePlayedOnTime = string.Format("{0}:{1}", ticketLine.GamePlayedOn.Hour, ticketLine.GamePlayedOn.Minute);
        }

        private void SetGamePlayedOn(TicketLine ticketLine)
        {
            var parts = ticketLine.GamePlayedOnTime.Split(':');
            var timespan = new TimeSpan(int.Parse(parts[0]), int.Parse(parts[1]), 0);
            ticketLine.GamePlayedOn = ticketLine.GamePlayedOn.Date + timespan;
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
                db.Entry(viewModel.TicketLine).State = EntityState.Modified;
                SetGamePlayedOn(viewModel.TicketLine);
                db.SaveChanges();
                return RedirectToAction(MVC.Tickets.Details(viewModel.TicketLine.TicketId));
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
            TicketLine ticketLine = db.TicketLine.Include(tl => tl.Ticket).SingleOrDefault(tl => tl.Id == id);
            SetGamePlayedOnTime(ticketLine);
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
            ticketLine.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction(MVC.Tickets.Details(ticketLine.TicketId));
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
