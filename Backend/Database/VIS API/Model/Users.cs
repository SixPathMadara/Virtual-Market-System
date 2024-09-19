using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIS_API.Model
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; } // Primary Key
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserPassword { get; set; }

    }

}
