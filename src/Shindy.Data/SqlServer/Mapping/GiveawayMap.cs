using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class GiveawayMap : EntityTypeConfiguration<Giveaway>
    {
        public GiveawayMap()
        {
            // Primary Key
            HasKey(t => t.GiveawayID);

            // Properties
            Property(t => t.GiveawayName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Description)
                .HasMaxLength(4000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.UpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Giveaway");
            Property(t => t.GiveawayID).HasColumnName("GiveawayID");
            Property(t => t.GiveawayName).HasColumnName("GiveawayName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.EventID).HasColumnName("EventID");
            Property(t => t.SponsorID).HasColumnName("SponsorID");
            Property(t => t.PersonID).HasColumnName("PersonID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            Property(t => t.UpdatedUser).HasColumnName("UpdatedUser");

            // Relationships
            HasOptional(t => t.Event)
                .WithMany(t => t.Giveaways)
                .HasForeignKey(d => d.EventID);
            HasOptional(t => t.Person)
                .WithMany(t => t.Giveaways)
                .HasForeignKey(d => d.PersonID);
            HasOptional(t => t.Sponsor)
                .WithMany(t => t.Giveaways)
                .HasForeignKey(d => d.SponsorID);

        }
    }
}
