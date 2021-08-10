﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo_Login2.Models.Entities
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [StringLength(10)]
        public string Ma { get; set; }
        //public int? IDKhoaDaoTao { get; set; }
        //[ForeignKey("IDKhoaDaoTao")]
        //public KhoaDaoTao KhoaDaoTao { get; set; }
        public string HoVaTen { get; set; }
        public string MailVL { get; set; }      
        public int PhanLoai { get; set; }
        public bool DaXem { get; set; }
        public string GhiChu { get; set; }
        public ICollection<AccountLopHoc> AccountLopHocs_IDAccount { get; set; }
        public ICollection<SinhVienLopHoc> SinhVienLopHocs_IDAccount { get; set; }

    }
}