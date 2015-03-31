using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class SponsorMap : EntityTypeConfiguration<Sponsor>
    {
        public SponsorMap()
        {
            // Primary Key
            HasKey(t => t.SponsorID);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.SponsorURI)
                .HasMaxLength(2000);

            Property(t => t.ImageURI)
                .HasMaxLength(2000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.UpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Sponsor");
            Property(t => t.SponsorID).HasColumnName("SponsorID");
            Property(t => t.Name).HasColumnName("SponsorName");
            Property(t => t.SponsorURI).HasColumnName("SponsorURI");
            Property(t => t.ImageURI).HasColumnName("ImageURI");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            Property(t => t.UpdatedUser).HasColumnName("UpdatedUser");
        }
    }
}
