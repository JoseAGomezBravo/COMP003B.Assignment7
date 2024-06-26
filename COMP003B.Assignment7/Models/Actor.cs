﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        [Required]
        public string ActorName { get; set; }

        [Required]
        public string MovieName { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }

        public int YearReleased { get; set; } // New property
    }
}
