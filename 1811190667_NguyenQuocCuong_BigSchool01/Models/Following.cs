using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1811190667_NguyenQuocCuong_BigSchool01.Models
{
    public class Following
    {
        [Key]
        [Column(Order = 1)]
        public string FollowerId { get; set; }
    }
}