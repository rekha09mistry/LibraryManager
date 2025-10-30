using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Author { get; set; }

        [Display(Name = "Published Year")]
        public int? PublishedYear { get; set; }

        [StringLength(100)]
        public string Genre { get; set; }

        public bool IsAvailable { get; set; } = true;

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
