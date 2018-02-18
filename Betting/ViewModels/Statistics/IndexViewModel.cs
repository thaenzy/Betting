using System;
using System.Collections.Generic;
using System.Web;

namespace Betting.ViewModels.Statistics
{
    public class IndexViewModel
    {
        public List<PlayerViewModel> Players { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}