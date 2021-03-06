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
        [DisplayName("Tên nhân viên")]
        public string DislayName { get; set; }
        [Column(TypeName = "varchar")]
        [Index(IsUnique =true)]
        [StringLength(50)]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]

        public string Password { get; set; }
        [DisplayName("Quyền")]

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
