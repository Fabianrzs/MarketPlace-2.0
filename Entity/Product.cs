using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Product
    {

        [Required]
        public int UniqueID { get; set; }

        [Required]
        public string Nmae { get; set; }

        [Required]
        public int Category { get; set; }

        [Required]
        public string Description { get; set; }

       // [Required]
       // public ??? Image { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public bool Enable { get; set; }

        [Required]
        public bool State { get; set; }

    }
}
