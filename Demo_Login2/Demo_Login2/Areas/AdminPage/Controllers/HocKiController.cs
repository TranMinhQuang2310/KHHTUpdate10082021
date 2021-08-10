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
    public class HocKiController : Controller
    {
        //LayDanhSachHocKi
        public ActionResult Index()
        {
            var lstHocKi = this.LayDanhSachHocKi();
            ViewBag.phanloaihocki = LayDanhSachPhanLoaiHocKi();
            return View(lstHocKi);
        }

        public List<HocKiDTO> LayDanhSachHocKi()
        {
            using(HocKiBusiness bs = new HocKiBusiness())
            {
                return bs.LayDanhSachHocKi();
            }
        }

        //Get : TaoHocKi
        public ActionResult Create()
        {
            ViewData["phanloaihocki"] = new SelectList(LayDanhSachPhanLoaiHocKi(), "ID", "LoaiHocKi");
            return View();
        }

        //Post : TaoHocKi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(HocKiDTO hocki)
        {
            var output = ThemHocKi(hocki);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public List<PhanLoaiHocKiDTO> LayDanhSachPhanLoaiHocKi()
        {
            using (PhanLoaiHocKiBusiness bs = new PhanLoaiHocKiBusiness())
            {
                return bs.LayDanhSachPhanLoaiHocKi();
            }
        }

        public bool ThemHocKi(HocKiDTO hocki)
        {
            using(HocKiBusiness bs = new HocKiBusiness())
            {
                return bs.ThemHocKi(hocki);
            }
        }

        //Get : SuaHocKi
        public ActionResult Edit(int id)
        {
            ViewData["phanloaihocki"] = new SelectList(LayDanhSachPhanLoaiHocKi(), "ID", "LoaiHocKi");
            HocKiDTO hocki = LayHocKi(id);
            return View(hocki);
        }

        //Post : SuaHocKi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(HocKiDTO hocki)
        {
            var output = SuaHocKi(hocki);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public HocKiDTO LayHocKi(int id)
        {
            using (HocKiBusiness bs = new HocKiBusiness())
            {
                return bs.LayHocKi(id);
            }
        }

        public bool SuaHocKi(HocKiDTO hocki)
        {
            using (HocKiBusiness bs = new HocKiBusiness())
            {
                return bs.SuaHocKi(hocki);
            }
        }

        //XoaHocKi
        public async Task<ActionResult> Delete(int id)
        {
            var output = XoaHocKi(id);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public bool XoaHocKi(int id)
        {
            using (HocKiBusiness bs = new HocKiBusiness())
            {
                return bs.XoaHocKi(id);
            }
        }

        //XemChiTietHocKi
        public ActionResult Details(int id)
        {
            var hocki = LayHocKi(id);
            ViewBag.phanloaihocki = LayDanhSachPhanLoaiHocKi();
            return View(hocki);
        }
    }


}