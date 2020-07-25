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
    public class FoodCategory
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        [DisplayName("Tên")]
        public string Name { get; set; }
        [DisplayName("Ngày thêm")]
        public DateTime CreateAt { get; set; }
        [DisplayName("Ngày cập nhật")]
        public DateTime UpdateAt { get; set; }

        public ICollection<Food> Foods { get; set; }

        public FoodCategory()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }
    }
}
