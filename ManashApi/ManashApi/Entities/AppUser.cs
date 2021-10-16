using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManashApi.Entities
{
    public class AppUser
    {
        [Key]
        public long Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
