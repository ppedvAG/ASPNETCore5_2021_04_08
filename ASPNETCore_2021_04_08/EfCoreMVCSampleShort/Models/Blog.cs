using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreMVCSampleShort.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Url { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }


        //Navigationsmöglichkeit 1:n
        public List<Comment> Comments { get; } = new List<Comment>();

    }
}
