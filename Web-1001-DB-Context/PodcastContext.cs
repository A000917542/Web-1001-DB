using Microsoft.EntityFrameworkCore;
using System;
using Web_1001_DB_Models;

namespace Web_1001_DB_Context
{
    public class PodcastContext : DbContext
    {
        public PodcastContext(DbContextOptions<PodcastContext> options)
            : base(options)
        { }

        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<PodcastEpisode> Episodes { get; set; }
    }
}
