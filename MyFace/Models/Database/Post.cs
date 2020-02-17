using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFace.Models.Database
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PostedAt { get; set; }
        public User PostedBy { get; set; }
        public IEnumerable<Interaction> Interactions { get; set; }
    }
}