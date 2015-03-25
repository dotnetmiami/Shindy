using System.Data.Entity.ModelConfiguration;
using Shindy.Model;

namespace Shindy.Data.SqlServer.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            HasKey(t => t.PersonID);

            // Properties
            Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.EMail)
                .HasMaxLength(320);

            Property(t => t.MemberURI)
                .HasMaxLength(2000);

            Property(t => t.TwitterName)
                .HasMaxLength(50);

            Property(t => t.LinkedinURI)
                .HasMaxLength(2000);

            Property(t => t.Bio)
                .HasMaxLength(4000);

            Property(t => t.PhotoURI)
                .HasMaxLength(2000);

            Property(t => t.Zip)
                .HasMaxLength(10);

            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.LastUpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Person");
            Property(t => t.PersonID).HasColumnName("PersonID");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.EMail).HasColumnName("EMail");
            Property(t => t.MemberURI).HasColumnName("MemberURI");
            Property(t => t.TwitterName).HasColumnName("TwitterName");
            Property(t => t.LinkedinURI).HasColumnName("LinkedinURI");
            Property(t => t.Bio).HasColumnName("Bio");
            Property(t => t.PhotoURI).HasColumnName("PhotoURI");
            Property(t => t.Zip).HasColumnName("Zip");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
            Property(t => t.LastUpdatedUser).HasColumnName("LastUpdatedUser");
        }
    }
}
