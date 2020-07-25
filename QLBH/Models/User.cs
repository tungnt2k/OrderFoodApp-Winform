using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public enum Role
    {
        ADMIN = 1,
        STAFF = 2
    }
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string DislayName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public ICollection<Bill> Bills { get; set; }

        public User()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }
    }
}
