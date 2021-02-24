using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string ProductName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string ProductCode { get; set; }

        public int Stock { get; set; }
        public decimal Pprice { get; set; }
        public decimal Sprice { get; set; }
        public bool Status { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string Image { get; set; }

        public decimal Mkg { get; set; }
        public decimal Kg { get; set; }

        public decimal Mt { get; set; }
        public decimal mt2 { get; set; }
        public decimal Tmt { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public string Color { get; set; }
        public decimal CriticalPoint { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}