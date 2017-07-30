using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace Betting.ViewModels.Tickets
{
    public class EditTicketLineViewModel
    {
        public IEnumerable<SelectListItem> Players { get; set; }
        public IEnumerable<SelectListItem> BetTypes { get; set; }
        public IEnumerable<SelectListItem> Results { get; set; }
        public TicketLineViewModel TicketLine { get; set; }
    }
    public class TicketLineViewModel
    {
        public TicketLine TicketLine { get; set; }

        [DisplayName("Tijd (uu:mm)")]
        public string TicketTime { get; set; }
        public TicketLineViewModel(TicketLine ticketLine)
        {
            TicketLine = ticketLine;
            var date = ticketLine.GamePlayedOn.GetValueOrDefault();
            TicketTime = date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
        }

        public TicketLineViewModel()
        {

        }
    }
    public class TicketViewModel
    {
        public Ticket Ticket { get; set; }
        public List<TicketLineViewModel> TicketLines { get; set; }

        public int AantalGoed
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.Won);
            }
        }
        public int AantalFout
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.Lost);
            }
        }
        public int AantalTeSpelen
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.NotPlayedYet);
            }
        }

        public TicketViewModel(Ticket ticket)
        {
            Ticket = ticket;
            TicketLines = ticket.TicketLine.OrderBy(tl => tl.GamePlayedOn).Select(l => new TicketLineViewModel(l)).ToList();
        }
    }
}