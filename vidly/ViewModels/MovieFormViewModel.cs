using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }
        [Display(Name = "Genres")]
        public int GenreId { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)

                    return "Edit Movie";

                return "New Movie";
            }
        }

        public MovieFormViewModel()
        {

        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}