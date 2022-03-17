using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_1001_DB_Context;
using Web_1001_DB_Models;
using System.Linq;
using System.Collections.Generic;

namespace Web_1001_DB_App.Pages
{
    public class EditPodcastModel : PageModel
    {
        private readonly PodcastContext _db;


        [FromForm]
        public Podcast podcast { get; set; }

        public PodcastEpisode episode { get; set; }

        public IList<PodcastEpisode> Episodes { get; set; }

        public EditPodcastModel(PodcastContext db)
        {
            _db = db;

            Episodes = _db.Episodes.ToList();
        }

        public void OnGet([FromQuery] int Id)
        {
            podcast = _db.Podcasts.Where(pd => pd.Id == Id).FirstOrDefault();
        }

        public void OnPost()
        {
            _db.Podcasts.Update(podcast);
            _db.SaveChangesAsync();
        }
    }
}
