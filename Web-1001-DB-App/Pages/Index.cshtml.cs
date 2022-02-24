using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_1001_DB_Context;
using Microsoft.EntityFrameworkCore;
using Web_1001_DB_Models;

namespace Web_1001_DB_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PodcastContext _db;

        public ICollection<Podcast> Podcasts { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PodcastContext db)
        {
            _logger = logger;
            _db = db;

            _logger.LogInformation("lajsdlfjasdjf");
        }

        public void OnGet()
        {
            ViewData["NumPodcasts"] = _db.Podcasts.Count();
            var podcastQuery = _db.Podcasts.Select(pd => pd);
            Podcasts = podcastQuery.ToList();
        }
    }
}
