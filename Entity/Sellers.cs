using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity
{
    public class Sellers: Users
    {

        public ICollection<Product> Product { get; set; }
    }
}
