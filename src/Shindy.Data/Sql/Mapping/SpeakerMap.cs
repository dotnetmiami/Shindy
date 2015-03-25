using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.Sql.Mapping
{
    public class SpeakerMap : EntityTypeConfiguration<Speaker>
    {
        public SpeakerMap()
        {
            // Primary Key
            HasKey(t => t.SessionPersonID);

            // Properties
            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Speaker");
            Property(t => t.SessionPersonID).HasColumnName("SessionPersonID");
            Property(t => t.SessionID).HasColumnName("SessionID");
            Property(t => t.PersonID).HasColumnName("PersonID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasRequired(t => t.Person)
                .WithMany(t => t.Speakers)
                .HasForeignKey(d => d.PersonID);
            HasRequired(t => t.Session)
                .WithMany(t => t.Speakers)
                .HasForeignKey(d => d.SessionID);

        }
    }
}
