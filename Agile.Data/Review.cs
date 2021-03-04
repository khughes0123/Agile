using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{ 

    public enum StarValue {One, Two, Three , Four, Five }

    
    public class Review
    {
        public StarValue Rating { get; set; }

        [MaxLength(1000, ErrorMessage = "Brevity is the soul of wit")]
        public string Summary { get; set; }

        [Required]
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public Guid CreaterID { get; set; }


    }


}
