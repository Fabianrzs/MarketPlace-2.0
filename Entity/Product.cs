using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity
{
    public class Product: BaseEntity
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public int Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public bool Enable { get; set; }



        public Seller Seller { get; set; }

        public Category Category { get; set; }
    }
}
