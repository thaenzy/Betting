namespace Betting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bet.TicketLine")]
    public partial class TicketLine
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        [DisplayName("Resultaat")]
        public int ResultId { get; set; }

        [DisplayName("Speler")]
        public int PlayerId { get; set; }

        [DisplayName("Gok")]
        public int BetTypeId { get; set; }

        [DisplayName("Quotering")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Odd { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(500)]
        [DisplayName("Wedstrijd")]
        public string Game { get; set; }
        
        [DisplayName("Speeldatum")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? GamePlayedOn { get; set; }

        public virtual BetType BetType { get; set; }

        [DisplayName("Speler")]
        public virtual Player Player { get; set; }

        [DisplayName("Resultaat")]
        public virtual Result Result { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
