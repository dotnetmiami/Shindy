using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.Sql.Mapping
{
    public class SponsorMap : EntityTypeConfiguration<Sponsor>
    {
        public SponsorMap()
        {
            // Primary Key
            HasKey(t => t.SponsorID);

            // Properties
            Property(t => t.SponsorName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.SponsorURI)
                .HasMaxLength(2000);

            Property(t => t.ImageURI)
                .HasMaxLength(2000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Sponsor");
            Property(t => t.SponsorID).HasColumnName("SponsorID");
            Property(t => t.SponsorName).HasColumnName("SponsorName");
            Property(t => t.SponsorURI).HasColumnName("SponsorURI");
            Property(t => t.ImageURI).HasColumnName("ImageURI");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");
        }
    }
}
