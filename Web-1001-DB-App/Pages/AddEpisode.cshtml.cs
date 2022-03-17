using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Web_1001_DB_Context;
using Web_1001_DB_Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web_1001_DB_App.Pages
{
    public class AddEpisodeModel : PageModel
    {
        private readonly PodcastContext _db;

        public IList<SelectListItem> PodcastList {get; set;}

        [FromForm]
        public PodcastEpisode episode { get; set; }

        public AddEpisodeModel(PodcastContext ctx)
        {
            _db = ctx;

            PodcastList = _db.Podcasts.Select(pod => new SelectListItem(pod.Name, pod.Id.ToString())).ToList();
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Add<PodcastEpisode>(episode);
                _db.SaveChangesAsync();
            }
        }
    }
}
