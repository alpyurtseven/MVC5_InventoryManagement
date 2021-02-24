using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class InvoiceP
    {
        [Key]
        public int InvoicePId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string PDescp { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoices { get; set; }

        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
    }
}