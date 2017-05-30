using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnRaoVat_ASP.NET.Areas.Administrator.Models
{
    public class LoginModels
    {
        [Required]
        public string SoDienThoai { get; set; }
        public string MatKhau { get; set; }
    }
}