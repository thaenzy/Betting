namespace Betting
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<BetType> BetType { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketLine> TicketLine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BetType>()
                .HasMany(e => e.TicketLine)
                .WithRequired(e => e.BetType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Competition)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.TicketLine)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Result>()
                .HasMany(e => e.TicketLine)
                .WithRequired(e => e.Result)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.TicketLine)
                .WithRequired(e => e.Ticket)
                .WillCascadeOnDelete(false);
        }
    }
}
