using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_1001_DB_Models
{
    public class PodcastEpisode
    {
        [Key]
        [Required]
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [Url]
        public Uri Url { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public long Duration { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Show Notes")]
        public string ShowNotes { get; set; }

        [ForeignKey("Podcast")]
        [Display(Name = "Podcast")]
        public int PodcastId { get; set; }

        public Podcast Podcast { get; set; }
    }
}
