using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public DateTime Checkout { get; set; }
        public float CustomerTake { get; set; }
        public float ReturnCustomer { get; set; }
        public bool Status { get; set; }
        [Required]
        public int StaffId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        
        [ForeignKey("StaffId")]
        public User Staff { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; }

        public Bill()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

    }
}
