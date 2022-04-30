using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LikeDto
    {
        public int Id { get; set; }
        public string username { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public string photoUrl { get; set; }
        public string City { get; set; }
    }
}