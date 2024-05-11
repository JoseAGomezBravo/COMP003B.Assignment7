using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models

{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string MovieName { get; set;}


        
    }
}
