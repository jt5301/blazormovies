﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Custom Error Message here")]
        public string Name { get; set; }
    }
}
