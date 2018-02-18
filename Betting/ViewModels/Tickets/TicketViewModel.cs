using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Betting.ViewModels.Tickets
{
    public class TicketViewModel
    {
        public Ticket Ticket { get; set; }
        public List<TicketLine> TicketLines { get; set; }

        public int TotalGoodBets
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.Won);
            }
        }
        public int TotalFaulthyBets
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.Lost);
            }
        }
        public int TotalBetsNotYetsPlayed
        {
            get
            {
                return Ticket.TicketLine.Count(l => l.ResultId == (int)ResultEnum.NotPlayedYet);
            }
        }

        public TicketViewModel(Ticket ticket)
        {
            Ticket = ticket;
            TicketLines = ticket.TicketLine.OrderBy(tl => tl.GamePlayedOn).ToList();
        }

        public TicketViewModel()
        {

        }
    }
}