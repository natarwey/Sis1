using System.ComponentModel.DataAnnotations;

namespace Sis1.Model
{
    public class Users
    {
        [Key]
        public int id_User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
