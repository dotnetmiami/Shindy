using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            // Primary Key
            HasKey(t => t.SessionID);

            // Properties
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Abstract)
                .HasMaxLength(4000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Session");
            Property(t => t.SessionID).HasColumnName("SessionID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Abstract).HasColumnName("Abstract");
            Property(t => t.SessionTypeID).HasColumnName("SessionTypeID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");

            // Relationships
            HasRequired(t => t.SessionType)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.SessionTypeID);

        }
    }
}
