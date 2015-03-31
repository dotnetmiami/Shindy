using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class SessionTypeMap : EntityTypeConfiguration<SessionType>
    {
        public SessionTypeMap()
        {
            // Primary Key
            HasKey(t => t.SessionTypeID);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Description)
                .HasMaxLength(250);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.UpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SessionType");
            Property(t => t.SessionTypeID).HasColumnName("SessionTypeID");
            Property(t => t.Name).HasColumnName("SessionTypeName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            Property(t => t.UpdatedUser).HasColumnName("UpdatedUser");
        }
    }
}
