using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int UniqueID { get; set; }
        [Required]
        public int State { get; set; }

    }
}
