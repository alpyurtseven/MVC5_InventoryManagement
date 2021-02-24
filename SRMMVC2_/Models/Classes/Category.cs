using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}