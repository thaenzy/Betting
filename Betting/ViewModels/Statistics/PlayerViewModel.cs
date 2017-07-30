using System.Linq;

namespace Betting.ViewModels.Statistics
{
    public class PlayerViewModel
    {
        public Player Player { get; set; }
        public decimal AverageOdd
        {
            get
            {
                if (Player.TicketLine.Any())
                {
                    return Player.TicketLine.Average(l => l.Odd);
                }
                return 0;
            }
        }
        public decimal AverageWonOdd
        {
            get
            {
                if (Player.TicketLine.Where(l => l.ResultEnum == ResultEnum.Won).Any())
                {
                    return Player.TicketLine.Where(l => l.ResultEnum == ResultEnum.Won).Average(l => l.Odd);
                }
                return 0;
            }
        }
        public decimal AverageLostOdd
        {
            get
            {
                if (Player.TicketLine.Where(l => l.ResultEnum == ResultEnum.Lost).Any())
                {
                    return Player.TicketLine.Where(l => l.ResultEnum == ResultEnum.Lost).Average(l => l.Odd);
                }
                return 0;
            }
        }
        public int TotalWonBets
        {
            get
            {
                if (Player.TicketLine.Any())
                {
                    return Player.TicketLine.Count(l => l.ResultEnum == ResultEnum.Won);
                }
                return 0;
            }
        }
        public int TotalLostBets
        {
            get
            {
                if (Player.TicketLine.Any())
                {
                    return Player.TicketLine.Count(l => l.ResultEnum == ResultEnum.Lost);
                }
                return 0;
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
}