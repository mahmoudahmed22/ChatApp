using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chat2.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public virtual AppUser UserAccount { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
