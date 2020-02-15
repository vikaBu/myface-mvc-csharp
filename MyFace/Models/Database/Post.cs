using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFace.Models.Database
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PostedAt { get; set; }
    }
}