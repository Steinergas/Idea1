using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Idea1.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }
        public string Title { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}