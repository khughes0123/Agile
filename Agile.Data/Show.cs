using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{
    public class Show
    {
        public int ShowId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public Guid CreaterID { get; set; }
        public int Episode { get; set; }
        public int Season { get; set; }
    }
}
