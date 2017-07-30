namespace Betting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bet.Competition")]
    public partial class Competition
    {
        public int Id { get; set; }

        public int CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}
