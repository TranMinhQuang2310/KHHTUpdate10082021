using Demo_Login2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Login2.Areas.AdminPage.Business
{
    public class PhanLoaiMonHocBusiness : BaseBusiness
    {
        public List<PhanLoaiMonHocDTO> LayDanhSachPhanLoaiMonHoc()
        {
            try
            {
                var listphanloaimonhoc = model.PhanLoaiMonHocs.Select(s => new PhanLoaiMonHocDTO
                {
                    ID = s.ID,
                    LoaiMonHoc = s.LoaiMonHoc,
                    GhiChu = s.GhiChu
                }).ToList();
                return listphanloaimonhoc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}