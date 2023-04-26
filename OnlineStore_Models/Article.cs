using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_Models
{
    public class Article
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        public int StoreId { get; set; }

        [MaxLength(200)]
        [Required]
        public string Code { get; set; }

        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Image { get; set; }

        [Required]
        public int Stock { get; set; }

        [ForeignKey("StoreId")]
        public Store Store { get; set; }
    }
}
