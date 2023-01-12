using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity
{
    public class User: BaseEntity
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int Role { get; set; }

        public void Encript()
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(Password);
            Password = Convert.ToBase64String(encryted);
        }
        public void DesEncript()
        {
            byte[] decryted = Convert.FromBase64String(Password);
            Password = System.Text.Encoding.Unicode.GetString(decryted);
        }

    }
}
