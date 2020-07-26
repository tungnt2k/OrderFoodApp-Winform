using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        [DisplayName("Tên KH")]
        public string CustomerName { get; set; }
        [DisplayName("Thời gian checkout")]
        public DateTime Checkout { get; set; }
        [DisplayName("Khách hàng đưa")]
        public float CustomerTake { get; set; }
        [DisplayName("Trả lại khách")]
        public float ReturnCustomer { get; set; }
        [DisplayName("Tổng tiền")]
        public float TotalPrice { get; set; }
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
