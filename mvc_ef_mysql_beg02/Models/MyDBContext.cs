namespace mvc_ef_mysql_beg02.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MyDBContext")
        {
        }

        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<personmaster> personmasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<address>()
            //    .Property(e => e.Address1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<address>()
            //    .Property(e => e.FullAddress)
            //    .IsUnicode(false);

            //modelBuilder.Entity<address>()
            //    .HasMany(e => e.personmasters)
            //    .WithOptional(e => e.address)
            //    .WillCascadeOnDelete();

            //modelBuilder.Entity<personmaster>()
            //    .Property(e => e.FIRSTNAME)
            //    .IsUnicode(false);

            //modelBuilder.Entity<personmaster>()
            //    .Property(e => e.LASTNAME)
            //    .IsUnicode(false);

            //modelBuilder.Entity<personmaster>()
            //    .Property(e => e.ADDRESS1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<personmaster>()
            //    .Property(e => e.ADDRESS2)
            //    .IsUnicode(false);
        }
    }
}
