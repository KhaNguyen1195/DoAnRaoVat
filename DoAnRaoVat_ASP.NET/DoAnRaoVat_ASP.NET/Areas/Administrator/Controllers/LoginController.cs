using DoAnRaoVat_ASP.NET.Areas.Administrator.Code;
using DoAnRaoVat_ASP.NET.Areas.Administrator.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnRaoVat_ASP.NET.Areas.Administrator.Controllers
{
    public class LoginController : Controller
    {
        // GET: Administrator/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModels model)
        {
            var result = new LoginModel().Login(model.SoDienThoai, model.MatKhau);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { SoDienThoai = model.SoDienThoai });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
    }
}