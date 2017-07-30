using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Betting.ViewModels.Statistics
{
    public class PlayerViewModel
    {
        public Player Player { get; set; }
        public decimal AverageOdd
        {
            get
            {
                return Player.TicketLine.Average(l => l.Odd);
            }
        }
        public int AantalGoed
        {
            get
            {
                return Player.TicketLine.Count(l => l.ResultEnum == ResultEnum.Won);
            }
        }
        public int AantalFout
        {
            get
            {
                return Player.TicketLine.Count(l => l.ResultEnum == ResultEnum.Lost);
            }
        }

        public PlayerViewModel(Player player)
        {
            Player = player;
        }

        public PlayerViewModel()
        {

        }
    }
    public class IndexViewModel
    {
        public List<PlayerViewModel> Players { get; set; }
    }
}