using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CommentSummary
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int NumberOfComments { get; set; }
    }
}