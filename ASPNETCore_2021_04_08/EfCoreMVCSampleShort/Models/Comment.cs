using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreMVCSampleShort.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }

        public int BlogId { get; set; }

        //Navigationsmöglichkeit gehe zu Parent-Object
        public Blog Blog { get; set; }
    }
}
