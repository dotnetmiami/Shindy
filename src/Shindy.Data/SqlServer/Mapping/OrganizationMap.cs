using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.SqlServer.Mapping
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            // Primary Key
            HasKey(t => t.OrgID);

            // Properties
            Property(t => t.OrgName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.OrgDescription)
                .HasMaxLength(250);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Organization");
            Property(t => t.OrgID).HasColumnName("OrgID");
            Property(t => t.OrgName).HasColumnName("OrgName");
            Property(t => t.OrgDescription).HasColumnName("OrgDescription");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");
        }
    }
}
