using PokemonReviewApp.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Text { get; set; }

        public int Rating { get; set; }

        public Reviewer? Reviewer { get; set; }

        public Pokemon? Pokemon { get; set; }
    }
}
