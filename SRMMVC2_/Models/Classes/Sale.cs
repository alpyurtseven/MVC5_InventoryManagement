using System;
using System.ComponentModel.DataAnnotations;

namespace SRMMVC2_.Models.Classes
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        //Product
        //Client
        //Staff
        public DateTime Date { get; set; }

        public int Piece { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Productid { get; set; }
        public int Staffid { get; set; }
        public int Clientid { get; set; }

        public virtual Product Products { get; set; }
        public virtual Client Clients { get; set; }
        public virtual Staff Staffs { get; set; }
    }
}