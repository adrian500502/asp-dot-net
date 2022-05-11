using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetAB.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        [Display(Name = "Cover"), DataType(DataType.ImageUrl), StringLength(100, MinimumLength = 3)]
        public string Image { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30, MinimumLength = 3, ErrorMessage = "The length is too short!")]
        public string Genre { get; set; }

        [Range(0, 1000), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5), Required]
        public string Rating { get; set; }

        [StringLength(150), DataType(DataType.Text)]
        public string Director { get; set; }

        [StringLength(150), DataType(DataType.Text)]
        public string Starring { get; set; }

        [StringLength(400), DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
