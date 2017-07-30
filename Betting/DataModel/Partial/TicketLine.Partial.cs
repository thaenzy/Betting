using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Betting
{
    public partial class TicketLine
    {
        public ResultEnum ResultEnum
        {
            get
            {
                return (ResultEnum)ResultId;
            }
        }
    }
}