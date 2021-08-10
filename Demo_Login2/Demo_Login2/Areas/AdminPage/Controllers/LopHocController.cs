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
    public class LopHocController : Controller
    {
        //LayDanhSachLopHoc
        public ActionResult Index()
        {
            var lstlophoc = this.LayDanhSachLopHoc();
            ViewBag.khoadaotao = LayDanhSachKhoaDaoTao();
            return View(lstlophoc);
        }

        public List<LopHocDTO> LayDanhSachLopHoc()
        {
            using (LopHocBusiness bs = new LopHocBusiness())
            {
                return bs.LayDanhSachLopHoc();
            }
        }

        //Get : TaoLopHoc
        public ActionResult Create()
        {
            ViewData["khoa"] = new SelectList(LayDanhSachKhoaDaoTao(), "ID", "TenKhoaDaoTao");
            return View();
        }

        //Post : TaoLopHoc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LopHocDTO lophoc)
        {
            var output = ThemLopHoc(lophoc);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public List<KhoaDaoTaoDTO> LayDanhSachKhoaDaoTao()
        {
            using (KhoaDaoTaoBusiness bs = new KhoaDaoTaoBusiness())
            {
                return bs.LayDanhSachKhoaDaoTao();
            }
        }

        public bool ThemLopHoc(LopHocDTO lophoc)
        {
            using (LopHocBusiness bs = new LopHocBusiness())
            {
                return bs.ThemLopHoc(lophoc);
            }
        }

        //Get:SuaLopHoc
        public ActionResult Edit(int id)
        {
            ViewData["khoa"] = new SelectList(LayDanhSachKhoaDaoTao(), "ID", "TenKhoaDaoTao");
            LopHocDTO lophoc = LayLopHoc(id);
            return View(lophoc);
        }

        //Post:SuaLopHoc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(LopHocDTO lophoc)
        {
            var output = SuaLopHoc(lophoc);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public LopHocDTO LayLopHoc(int id)
        {
            using (LopHocBusiness bs = new LopHocBusiness())
            {
                return bs.LayLopHoc(id);
            }
        }

        public bool SuaLopHoc(LopHocDTO lophoc)
        {
            using (LopHocBusiness bs = new LopHocBusiness())
            {
                return bs.SuaLopHoc(lophoc);
            }
        }

        //XoaLopHoc
        public async Task<ActionResult> Delete(int id)
        {
            var output = XoaLopHoc(id);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public bool XoaLopHoc(int id)
        {
            using (LopHocBusiness bs = new LopHocBusiness())
            {
                return bs.XoaLopHoc(id);
            }
        }

        //XemChiTietLopHoc
        public ActionResult Details(int id)
        {
            var lophoc = LayLopHoc(id);
            ViewBag.khoadaotao = LayDanhSachKhoaDaoTao();
            return View(lophoc);
        }
    }
}