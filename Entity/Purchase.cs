using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Purchase
    {
        [Required]
        public int UniqueID { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public bool StatePurchase { get; set; }

        [Required]
        public int FullValue { get; set; }
        
        [Required]
        public bool State { get; set; }


    }
}
