using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
    }
}
