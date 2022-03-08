using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Web_1001_DB_Models
{
    public class Podcast
    {
        [Key]
        [Required]
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        [Required]
        public Uri Url { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<PodcastEpisode> Episodes { get; set; }
    }
}
