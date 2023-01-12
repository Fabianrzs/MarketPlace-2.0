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

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
