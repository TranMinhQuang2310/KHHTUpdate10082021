using Demo_Login2.Areas.AdminPage.Business;
using Demo_Login2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Demo_Login2.Areas.AdminPage.Controllers
{
    public class LoaiHinhDaoTaoController : Controller
    {
        //LaydanhsachLoaiHinhDaoTao
        public ActionResult Index()
        {
            var lstloaihinhDT = this.LayDanhSachLoaiHinhDaoTao();
            return View(lstloaihinhDT);
        }
        public List<LoaiHinhDaoTaoDTO> LayDanhSachLoaiHinhDaoTao()
        {
            using(LoaiHinhDaoTaoBusiness bs = new LoaiHinhDaoTaoBusiness())
            {
                return bs.LayDanhSachLoaiHinhDaoTao();
            }
        }

        //Get : TaoLoaiHinhDaoTao
        public ActionResult Create()
        {
            return View();
        }
        //Post : TaoLoaiHinhDaoTao
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LoaiHinhDaoTaoDTO loaihinhDT)
        {
            var output = ThemLoaiHinhDaoTao(loaihinhDT);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }


        public bool ThemLoaiHinhDaoTao(LoaiHinhDaoTaoDTO loaihinhDT)
        {
            using(LoaiHinhDaoTaoBusiness bs = new LoaiHinhDaoTaoBusiness())
            {
                return bs.ThemLoaiHinhDaoTao(loaihinhDT);
            }
        }

        //Get : SuaLoaiHinhDaoTao
        public ActionResult Edit(int id)
        {
            LoaiHinhDaoTaoDTO loaihinhDT = LayLoaiHinhDaoTao(id);
            return View(loaihinhDT);
        }

        //Post : SuaLoaiHinhDaoTao
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(LoaiHinhDaoTaoDTO loaihinhDT)
        {
            var output = SuaLoaiHinhDaoTao(loaihinhDT);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public LoaiHinhDaoTaoDTO LayLoaiHinhDaoTao(int id)
        {
            using(LoaiHinhDaoTaoBusiness bs = new LoaiHinhDaoTaoBusiness())
            {
                return bs.LayLoaiHinhDaoTao(id);
            }
        }

        public bool SuaLoaiHinhDaoTao(LoaiHinhDaoTaoDTO loaihinhDT)
        {
            using(LoaiHinhDaoTaoBusiness bs = new LoaiHinhDaoTaoBusiness())
            {
                return bs.SuaLoaiHinhDaoTao(loaihinhDT);
            }
        }

        //XoaLoaiHinhDaoTao
        public async Task<ActionResult> Delete(int id)
        {
            var output = XoaLoaiHinhDaoTao(id);
            if (output)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Fail");
            }
        }

        public bool XoaLoaiHinhDaoTao(int id)
        {
            using (LoaiHinhDaoTaoBusiness bs = new LoaiHinhDaoTaoBusiness())
            {
                return bs.XoaLoaiHinhDaoTao(id);
            }
        }

        //XemChiTietLoaiHinhDaoTao
        public ActionResult Details(int id)
        {
            var loaihinhDT = LayLoaiHinhDaoTao(id);
            return View(loaihinhDT);
        }
    }
}