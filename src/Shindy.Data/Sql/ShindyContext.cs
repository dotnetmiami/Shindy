using System.Data.Entity;
using Shindy.Data.Sql.Mapping;
using Shindy.Model;

namespace Shindy.Data.Sql
{
    public class ShindyContext : DbContext
    {
        static ShindyContext()
        {
            Database.SetInitializer<ShindyContext>(null);
        }

        public ShindyContext()
            : base("Name=ShindyContext")
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSession> EventSessions { get; set; }
        public DbSet<EventSponsor> EventSponsors { get; set; }
        public DbSet<Giveaway> Giveaways { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrgEvent> OrgEvents { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionType> SessionTypes { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendeeMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventSessionMap());
            modelBuilder.Configurations.Add(new EventSponsorMap());
            modelBuilder.Configurations.Add(new GiveawayMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new OrgEventMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new SessionMap());
            modelBuilder.Configurations.Add(new SessionTypeMap());
            modelBuilder.Configurations.Add(new SpeakerMap());
            modelBuilder.Configurations.Add(new SponsorMap());
        }
    }
}
