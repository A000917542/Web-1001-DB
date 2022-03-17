using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_1001_DB_Context;
using Web_1001_DB_Models;

namespace Web_1001_DB_App.Pages
{
    public class EditEpisodeModel : PageModel
    {
        private readonly PodcastContext _db;

        [FromForm]
        public PodcastEpisode episode { get; set; }

        public EditEpisodeModel(PodcastContext ctx)
        {
            _db = ctx;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            _db.Add<PodcastEpisode>(episode);
            _db.SaveChangesAsync();
        }
    }
}
