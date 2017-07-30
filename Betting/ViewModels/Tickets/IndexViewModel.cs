using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Betting.ViewModels.Tickets
{
    public class IndexViewModel
    {
        public List<TicketViewModel> Tickets { get; set; }
        public IndexViewModel(IEnumerable<Ticket> tickets)
        {
            Tickets = new List<TicketViewModel>();
            Tickets.AddRange(tickets.Select(t => new TicketViewModel(t)));
        }
    }
}