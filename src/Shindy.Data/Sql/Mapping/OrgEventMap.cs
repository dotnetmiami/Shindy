using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.Sql.Mapping
{
    public class OrgEventMap : EntityTypeConfiguration<OrgEvent>
    {
        public OrgEventMap()
        {
            // Primary Key
            HasKey(t => t.OrgEventID);

            // Properties
            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("OrgEvent");
            Property(t => t.OrgEventID).HasColumnName("OrgEventID");
            Property(t => t.OrgID).HasColumnName("OrgID");
            Property(t => t.EventID).HasColumnName("EventID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasRequired(t => t.Event)
                .WithMany(t => t.OrgEvents)
                .HasForeignKey(d => d.EventID);
            HasRequired(t => t.Organization)
                .WithMany(t => t.OrgEvents)
                .HasForeignKey(d => d.OrgID);

        }
    }
}
