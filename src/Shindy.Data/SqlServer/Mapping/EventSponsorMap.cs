using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class EventSponsorMap : EntityTypeConfiguration<EventSponsor>
    {
        public EventSponsorMap()
        {
            // Primary Key
            HasKey(t => t.EventSponsorID);

            // Properties
            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("EventSponsor");
            Property(t => t.EventSponsorID).HasColumnName("EventSponsorID");
            Property(t => t.EventID).HasColumnName("EventID");
            Property(t => t.SponsorID).HasColumnName("SponsorID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasRequired(t => t.Event)
                .WithMany(t => t.EventSponsors)
                .HasForeignKey(d => d.EventID);
            HasRequired(t => t.Sponsor)
                .WithMany(t => t.EventSponsors)
                .HasForeignKey(d => d.SponsorID);

        }
    }
}
