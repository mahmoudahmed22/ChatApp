using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chat2.Models
{
    public class Message
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }

        public DateTime when { get; set; }

        public AppUser To { get; set; }

        public string UserID { get; set; }

        public virtual AppUser Sender{get;set;}
    }
}
