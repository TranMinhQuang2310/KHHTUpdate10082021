﻿using Demo_Login2.Areas.AdminPage.Business;
using Demo_Login2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Demo_Login2.Areas.AdminPage.Controllers
{
    public class KhoaBoMonController : Controller
    {
        //LaydanhsachKhoaBoMon
        public ActionResult Index()
        {
            var lstkhoabm = this.LayDanhSachKhoaBoMon();
            return View(lstkhoabm);
        }

        public List<KhoaBoMonDTO> LayDanhSachKhoaBoMon()
        {
            using (KhoaBoMonBusiness bs = new KhoaBoMonBusiness())
            {
                return bs.LayDanhSachKhoaBoMon();
            }
        }

        //Get : TaoKhoaBoMon
        public ActionResult Create()
        {
            return View();
        }

        //Post : TaoLoaiHinhDaoTao
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(KhoaBoMonDTO khoabm)
        {
            var output = ThemKhoaBoMon(khoabm);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public bool ThemKhoaBoMon(KhoaBoMonDTO khoabm)
        {
            using (KhoaBoMonBusiness bs = new KhoaBoMonBusiness())
            {
                return bs.ThemKhoaBoMon(khoabm);
            }
        }

        //Get : SuaKhoaBoMon
        public ActionResult Edit(int id)
        {
            KhoaBoMonDTO khoabm = LayKhoaBoMon(id);
            return View(khoabm);
        }

        //Post : SuaKhoaBoMon
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(KhoaBoMonDTO khoabm)
        {
            var output = SuaKhoaBoMon(khoabm);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public KhoaBoMonDTO LayKhoaBoMon(int id)
        {
            using(KhoaBoMonBusiness bs = new KhoaBoMonBusiness())
            {
                return bs.LayKhoaBoMon(id);
            }
        }

        public bool SuaKhoaBoMon(KhoaBoMonDTO khoabm)
        {
            using(KhoaBoMonBusiness bs = new KhoaBoMonBusiness())
            {
                return bs.SuaKhoaBoMon(khoabm);
            }
        }

        //XoaKhoaBoMon
        public async Task<ActionResult> Delete(int id)
        {
            var output = XoaKhoaBoMon(id);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public bool XoaKhoaBoMon(int id)
        {
            using(KhoaBoMonBusiness bs = new KhoaBoMonBusiness())
            {
                return bs.XoaKhoaBoMon(id);
            }
        }

        //XemChiTietKhoaBoMon
        public ActionResult Details(int id)
        {
            var khoabm = LayKhoaBoMon(id);
            return View(khoabm);
        }
    }
}