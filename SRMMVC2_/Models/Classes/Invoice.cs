using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public int ClientId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Nu { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(240)]
        public string Description { get; set; }

        public virtual Client Clients { get; set; }

        public int StaffId { get; set; }
        public virtual Staff Staffs { get; set; }

        public ICollection<InvoiceP> InvoicePs { get; set; }
    }
}