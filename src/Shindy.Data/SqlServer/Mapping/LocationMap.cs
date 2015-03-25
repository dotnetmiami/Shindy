using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.SqlServer.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            HasKey(t => t.LocationID);

            // Properties
            Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.LocationURI)
                .HasMaxLength(2000);

            Property(t => t.Street1)
                .HasMaxLength(75);

            Property(t => t.Street2)
                .HasMaxLength(75);

            Property(t => t.City)
                .HasMaxLength(50);

            Property(t => t.State)
                .HasMaxLength(50);

            Property(t => t.ZipCode)
                .HasMaxLength(10);

            Property(t => t.MapURI)
                .HasMaxLength(2000);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Location");
            Property(t => t.LocationID).HasColumnName("LocationID");
            Property(t => t.LocationName).HasColumnName("LocationName");
            Property(t => t.LocationURI).HasColumnName("LocationURI");
            Property(t => t.Street1).HasColumnName("Street1");
            Property(t => t.Street2).HasColumnName("Street2");
            Property(t => t.City).HasColumnName("City");
            Property(t => t.State).HasColumnName("State");
            Property(t => t.ZipCode).HasColumnName("ZipCode");
            Property(t => t.MapURI).HasColumnName("MapURI");
            Property(t => t.Latitude).HasColumnName("Latitude");
            Property(t => t.Longitude).HasColumnName("Longitude");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");
        }
    }
}
