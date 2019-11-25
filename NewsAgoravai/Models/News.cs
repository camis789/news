using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Photo { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
