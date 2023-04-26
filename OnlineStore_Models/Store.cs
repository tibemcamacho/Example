using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_Models
{
    public class Store
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Branch { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public ICollection<Article> Articles { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
