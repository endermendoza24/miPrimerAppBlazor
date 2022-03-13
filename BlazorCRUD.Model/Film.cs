using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorCRUD.Model
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Name is too long.")]
        public string Director { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Name is too long.")]
        public DateTime ReleaseDate { get; set; }


    }
}
