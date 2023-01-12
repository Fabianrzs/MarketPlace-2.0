using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Buyer: Users
    {


        public ICollection<Purchase> Purchase { get; set; }

    }
}
