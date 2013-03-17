using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Movies2012.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}