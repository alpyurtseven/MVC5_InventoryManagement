using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRMMVC2_.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Username { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Password { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Authority { get; set; }
    }
}