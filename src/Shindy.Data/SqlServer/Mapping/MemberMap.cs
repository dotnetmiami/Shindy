using System.Data.Entity.ModelConfiguration;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer.Mapping
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            // Primary Key
            HasKey(t => t.MemberID);

            // Properties
            Property(t => t.CreatedUser)
                .HasMaxLength(50);

            Property(t => t.UpdatedUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Member");
            Property(t => t.MemberID).HasColumnName("MemberID");
            Property(t => t.OrgID).HasColumnName("OrgID");
            Property(t => t.PersonID).HasColumnName("PersonID");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            Property(t => t.UpdatedUser).HasColumnName("UpdatedUser");

            // Relationships
            HasRequired(t => t.Organization)
                .WithMany(t => t.Members)
                .HasForeignKey(d => d.OrgID);
            HasRequired(t => t.Person)
                .WithMany(t => t.Members)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
