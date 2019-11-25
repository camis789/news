using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string DoComment { get; set; }

        public virtual News News { get; set; }

    }
}
