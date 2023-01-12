using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity
{
    internal class PurchaseDetail
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
        public double Value { get; set; }



        public Purchase Purchase { get; set; }

        public Product Product { get; set; }

    }
}
