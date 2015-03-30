using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class EventSessionMap : EntityTypeConfiguration<EventSession>
    {
        public EventSessionMap()
        {
            // Primary Key
            HasKey(t => t.EventSessionID);

            // Properties
            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("EventSession");
            Property(t => t.EventSessionID).HasColumnName("EventSessionID");
            Property(t => t.EventID).HasColumnName("EventID");
            Property(t => t.SessionID).HasColumnName("SessionID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasRequired(t => t.Event)
                .WithMany(t => t.EventSessions)
                .HasForeignKey(d => d.EventID);
            HasRequired(t => t.Session)
                .WithMany(t => t.EventSessions)
                .HasForeignKey(d => d.SessionID);

        }
    }
}
