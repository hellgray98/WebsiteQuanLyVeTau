﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLVT.Models;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        private QuanLyVeTauContextEntities db = new QuanLyVeTauContextEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            // Kiểm tra đăng nhập
            if (Session["user"] == null)
            {
                ViewBag.ListError = new List<string>();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            var lsError = new List<string>();
            var currentUser = db.Users.Where(m => m.UserName == UserName).SingleOrDefault();

            if (currentUser == null)
            {
                lsError.Add("Sai tài khoản hoặc mặt khẩu");
            }
            else if (currentUser.Password != Password)
            {
                lsError.Add("Sai tài khoản hoặc mặt khẩu");
            }

            // Khi có lỗi
            if (lsError.Count > 0)
            {
                ViewBag.ListError = lsError;
                return View();
            }
            else
            {
                Session["user"] = currentUser;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Login", "Home");
        }

    }
}