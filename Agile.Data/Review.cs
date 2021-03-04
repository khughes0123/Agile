using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{
    public enum StarValue { 1, 2, 3, 4, 5}
    public class Review
    {
        public StarValue StarValue { get; set; }
    }
}
