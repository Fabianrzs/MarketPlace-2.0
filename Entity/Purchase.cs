using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity
{
    internal class Purchase: BaseEntity
    {
        [Required]
        public DateTime Date { set => new DateTime(); }

        [Required]
        public bool StatePurchase { get; set; }

        [Required]
        public double FullValue { get; set; }

<<<<<<< HEAD
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
=======

        public ICollection<PurchaseDetails> PurchaseDetails { get; set; }



        public Buyer Buyer { get; set; }

>>>>>>> 4b90cf00a07d4de78d653f2c8193262e31daf0c8
    }
}
