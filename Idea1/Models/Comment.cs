using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Idea1.Models
{
    public class Comment
    {
        [Key]
        public int Comment_id { get; set; }
        public string Comment_text { get; set; }
        public DateTime Comment_date { get; set; }
        public int Comment_like { get; set; }
        public int Comment_dislike { get; set; }
    }
}