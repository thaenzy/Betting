using Betting.ViewModels.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace Betting.Controllers
{
    public partial class StatisticsController : Controller
    {
        private DataModel db = new DataModel();

        // GET: Tickets
        public virtual ActionResult Index()
        {
            var players = db.Player.Include(p => p.TicketLine)
                .ToList();
            var vm = new IndexViewModel() { Players = players.Select(p => new PlayerViewModel(p)).ToList() };
            return View(vm);
        }
    }
}