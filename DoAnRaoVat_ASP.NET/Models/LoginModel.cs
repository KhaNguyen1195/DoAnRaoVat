using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LoginModel
    {
        private DoAnRaoVatDBContext context = null;
        public LoginModel()
        {
            context = new DoAnRaoVatDBContext();
        }
        public bool Login(string SoDienThoai, string MatKhau)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@SoDienThoai", SoDienThoai),
                new SqlParameter("@MatKhau", MatKhau),
            };
            var res = context.Database.SqlQuery<bool>("sp_account_login @SoDienThoai,@MatKhau", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
