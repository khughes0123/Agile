using Agile.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Models
{
    public enum StarValue { One, Two, Three, Four, Five }
    public class ReviewCreate
    {
        public int MovieId { get; set; }

        [MaxLength(1000, ErrorMessage = "Brevity is the soul of wit")]
        public string Summary { get; set; }

        public StarValue Rating { get; set; }
    }
}
