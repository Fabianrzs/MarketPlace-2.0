using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class PurchaseDetails
    {
        [Required]
        public int UniqueID { get; set; }

        [Required]
        public int IdPurchase { get; set; }

        [Required]
        public int IdProducts { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public bool State { get; set; }

    }
}
