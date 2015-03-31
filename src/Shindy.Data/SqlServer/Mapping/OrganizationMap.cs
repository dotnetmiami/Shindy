using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            // Primary Key
            HasKey(t => t.OrgID);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Description)
                .HasMaxLength(4000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.UpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Organization");
            Property(t => t.OrgID).HasColumnName("OrgID");
            Property(t => t.Name).HasColumnName("OrgName");
            Property(t => t.Description).HasColumnName("OrgDescription");
            Property(t => t.OrgUri).HasColumnName("OrgURI");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            Property(t => t.UpdatedUser).HasColumnName("UpdatedUser");
        }
    }
}
