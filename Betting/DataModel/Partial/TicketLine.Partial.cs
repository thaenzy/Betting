using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Betting
{
    public partial class TicketLine
    {
        [DisplayName("Tijd (uu:mm)")]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string GamePlayedOnTime { get; set; }
        public ResultEnum ResultEnum
        {
            get
            {
                return (ResultEnum)ResultId;
            }
        }
    }
}