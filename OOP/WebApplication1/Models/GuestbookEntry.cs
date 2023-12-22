using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GuestbookEntry 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите Ваше имя")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Введиите ваше сообщение")]
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}