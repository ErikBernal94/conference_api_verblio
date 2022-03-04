using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Conference.DL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Conference.DL.Context
{
    public class ConferenceContext: DbContext
    {
        private readonly IConfiguration Config;
        public virtual DbSet<Talk> Talks { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<Attendee> Atendees { get; set; }

        public ConferenceContext(DbContextOptions<ConferenceContext> options, IConfiguration config) : base(options)
        {
            Config = config;
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Config.GetValue<string>("SchemaName"));
            modelBuilder.Entity<Talk>()
                .HasOne(s => s.speaker)
                .WithOne(i => i.talk)
                .HasForeignKey<Speaker>(b => b.idTalk);

            modelBuilder.Entity<Speaker>();
            modelBuilder.Entity<Attendee>()
                .HasOne(a => a.talk)
                .WithMany(b => b.attendees)
                .HasForeignKey(a => a.idTalk);
            base.OnModelCreating(modelBuilder);
        }
    }
}
