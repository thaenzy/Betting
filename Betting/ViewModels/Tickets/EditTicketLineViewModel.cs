using System.Collections.Generic;
using System.Web.Mvc;

namespace Betting.ViewModels.Tickets
{
    public class EditTicketLineViewModel
    {
        public IEnumerable<SelectListItem> Players { get; set; }
        public IEnumerable<SelectListItem> BetTypes { get; set; }
        public IEnumerable<SelectListItem> Results { get; set; }
        public TicketLine TicketLine { get; set; }

        public EditTicketLineViewModel(TicketLine ticketLine)
        {
            TicketLine = ticketLine;
        }

        public EditTicketLineViewModel()
        {

        }
    }
}