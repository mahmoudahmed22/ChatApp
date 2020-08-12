using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chat2.Models
{
    public class AppUser:IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }
    }
}
