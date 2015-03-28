using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Shindy.Core.Entities;

namespace Shindy.Data.SqlServer
{
    public interface IShindyContext
    {
        DbSet<Attendee> Attendees { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<EventSession> EventSessions { get; set; }
        DbSet<EventSponsor> EventSponsors { get; set; }
        DbSet<Giveaway> Giveaways { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<Organization> Organizations { get; set; }
        DbSet<OrgEvent> OrgEvents { get; set; }
        DbSet<Person> People { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<SessionType> SessionTypes { get; set; }
        DbSet<Speaker> Speakers { get; set; }
        DbSet<Sponsor> Sponsors { get; set; }
        Database Database { get; }
        DbChangeTracker ChangeTracker { get; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}