using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class BillInfo
    {
        [Key]
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int BillId { get; set; }
        public int Count { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }

        [ForeignKey("BillId")]
        public Bill Bill { get; set; }

        public BillInfo()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }
    }
}
