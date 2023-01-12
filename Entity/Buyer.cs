using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Buyer: User
    {
        public ICollection<Purchase> Purchase { get; set; }

    }
}
