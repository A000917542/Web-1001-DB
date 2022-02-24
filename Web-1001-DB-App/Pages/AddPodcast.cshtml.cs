using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_1001_DB_Context;
using Web_1001_DB_Models;

namespace Web_1001_DB_App.Pages
{
    public class AddPodcastModel : PageModel
    {
        private readonly PodcastContext _db;

        [FromForm]
        public Podcast podcast { get; set; }

        public AddPodcastModel(PodcastContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _db.Add<Podcast>(podcast);
            _db.SaveChangesAsync();
        }
    }
}
