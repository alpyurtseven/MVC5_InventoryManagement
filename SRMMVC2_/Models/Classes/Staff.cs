using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string StaffName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string StaffSurname { get; set; }

        public bool Status { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}