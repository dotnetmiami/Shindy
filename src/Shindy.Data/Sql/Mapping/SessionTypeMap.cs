using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.Sql.Mapping
{
    public class SessionTypeMap : EntityTypeConfiguration<SessionType>
    {
        public SessionTypeMap()
        {
            // Primary Key
            HasKey(t => t.SessionTypeID);

            // Properties
            Property(t => t.SessionTypeName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Description)
                .HasMaxLength(250);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SessionType");
            Property(t => t.SessionTypeID).HasColumnName("SessionTypeID");
            Property(t => t.SessionTypeName).HasColumnName("SessionTypeName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");
        }
    }
}
