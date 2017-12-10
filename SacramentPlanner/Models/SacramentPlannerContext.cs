using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SacramentPlanner.Models
{
    public partial class SacramentPlannerContext : DbContext
    {
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<Speaker> Speaker { get; set; }

        public SacramentPlannerContext(DbContextOptions<SacramentPlannerContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.Property(e => e.MeetingId).HasColumnName("Meeting_Id");

                entity.Property(e => e.ClosingHymn).HasColumnName("Closing_Hymn");

                entity.Property(e => e.ClosingPrayer).HasColumnName("Closing_Prayer");

                entity.Property(e => e.Conductor).IsRequired();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IntermediateHymn).HasColumnName("Intermediate_Hymn");

                entity.Property(e => e.OpeningHymn)
                    .IsRequired()
                    .HasColumnName("Opening_Hymn");

                entity.Property(e => e.OpeningPrayer)
                    .IsRequired()
                    .HasColumnName("Opening_Prayer");

                entity.Property(e => e.SacramentHymn)
                    .IsRequired()
                    .HasColumnName("Sacrament_Hymn");

                entity.Property(e => e.SpeakerId).HasColumnName("Speaker_Id");

                entity.HasOne(d => d.Speaker)
                    .WithMany(p => p.Meeting)
                    .HasForeignKey(d => d.SpeakerId)
                    .HasConstraintName("FK_Meeting_Speaker_SpeakerId");
            });

            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.Property(e => e.SpeakerId).HasColumnName("Speaker_Id");

                entity.Property(e => e.Subject).IsRequired();
            });
        }
    }
}
