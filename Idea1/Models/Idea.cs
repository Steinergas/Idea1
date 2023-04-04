using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Idea1.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string Content { get; set; }
        public virtual List<Comment> Comments { get; set; }
        /*
        public int CategoryId { get; set; }
        public virtual Category Caterogy { get; set; }*/

    }
}