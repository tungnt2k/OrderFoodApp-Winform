﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        [DisplayName("Tên món")]
        public string Name { get; set; }
        [Required]
        public byte[] Content { get; set; }
        [Required]
        [DisplayName("Giá")]
        public float Price { get; set; }
        [Required]
        [DisplayName("Mã danh mục")]
        public int FoodCategoryId { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime CreateAt { get; set; }
        [DisplayName("Ngày sửa")]
        public DateTime UpdateAt { get; set; }

        [ForeignKey("FoodCategoryId")]
        public FoodCategory FoodCategory { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; }

        public Food()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }


    }
}
