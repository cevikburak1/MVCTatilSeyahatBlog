﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Tatil_Sehayat.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}