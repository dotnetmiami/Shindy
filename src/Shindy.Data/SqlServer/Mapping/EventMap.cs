using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.SqlServer.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            HasKey(t => t.EventID);

            // Properties
            Property(t => t.Title)
                .HasMaxLength(250);

            Property(t => t.Description)
                .HasMaxLength(4000);

            Property(t => t.RegistrationURI)
                .HasMaxLength(2000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Event");
            Property(t => t.EventID).HasColumnName("EventID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.StartDate).HasColumnName("StartDate");
            Property(t => t.EndDate).HasColumnName("EndDate");
            Property(t => t.LocationID).HasColumnName("LocationID");
            Property(t => t.RegistrationURI).HasColumnName("RegistrationURI");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasOptional(t => t.Location)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.LocationID);

        }
    }
}
