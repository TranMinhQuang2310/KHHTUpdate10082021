﻿using Demo_Login2.Models.DTO;
using Demo_Login2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Login2.Areas.AdminPage.Business
{
    public class MonHocBusiness : BaseBusiness
    {
        public MonHocDTO LayMonHoc(int id)
        {
            try
            {
                var monhoc = model.MonHocs.Where(s => s.ID == id).Select(s => new MonHocDTO {
                    ID = s.ID,
                    IDKhoaBoMon = s.IDKhoaBoMon,
                    MaMonHoc = s.MaMonHoc,
                    TenMonHoc = s.TenMonHoc,
                    HocPhanTienQuyet = s.HocPhanTienQuyet,
                    HocPhanHocTruoc = s.HocPhanHocTruoc,
                    SoTiet = s.SoTiet,
                    SoTietLyThuyet = s.SoTietLyThuyet,
                    SoTietThucHanh = s.SoTietThucHanh,
                    LoaiMonHoc = s.LoaiMonHoc,
                    SoTinChi = s.SoTinChi,
                    GhiChu = s.GhiChu
                }).FirstOrDefault();
                return monhoc;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<MonHocDTO> LayDanhSachMonHoc()
        {
            try
            {
                var listmonhoc = model.MonHocs.Select(s => new MonHocDTO
                {
                    ID = s.ID,
                    IDKhoaBoMon = s.IDKhoaBoMon,
                    MaMonHoc = s.MaMonHoc,
                    TenMonHoc = s.TenMonHoc,
                    HocPhanTienQuyet = s.HocPhanTienQuyet,
                    HocPhanHocTruoc = s.HocPhanHocTruoc,
                    SoTiet = s.SoTiet,
                    SoTietLyThuyet = s.SoTietLyThuyet,
                    SoTietThucHanh = s.SoTietThucHanh,
                    LoaiMonHoc = s.LoaiMonHoc,
                    SoTinChi = s.SoTinChi,
                    GhiChu = s.GhiChu
                }).ToList();
                return listmonhoc;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public bool ThemMonHoc(MonHocDTO monhoc)
        {
            try
            {
                var newmonhoc = new MonHoc();
                newmonhoc.ID = monhoc.ID;
                newmonhoc.IDKhoaBoMon = monhoc.IDKhoaBoMon;
                newmonhoc.MaMonHoc = monhoc.MaMonHoc;
                newmonhoc.TenMonHoc = monhoc.TenMonHoc;
                newmonhoc.HocPhanTienQuyet = monhoc.HocPhanTienQuyet;
                newmonhoc.HocPhanHocTruoc = monhoc.HocPhanHocTruoc;
                newmonhoc.SoTiet = monhoc.SoTiet;
                newmonhoc.SoTietLyThuyet = monhoc.SoTietLyThuyet;
                newmonhoc.SoTietThucHanh = monhoc.SoTietThucHanh;
                newmonhoc.LoaiMonHoc = monhoc.LoaiMonHoc;
                newmonhoc.SoTinChi = monhoc.SoTinChi;
                newmonhoc.GhiChu = monhoc.GhiChu;

                model.MonHocs.Add(newmonhoc);
                model.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaMonHoc(int id)
        {
            try
            {
                var monhoc = model.MonHocs.Where(s => s.ID == id).FirstOrDefault();
                model.MonHocs.Remove(monhoc);
                model.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool SuaMonHoc(MonHocDTO monhoc)
        {
            try
            {
                var monhocs = model.MonHocs.Where(s => s.ID == monhoc.ID).FirstOrDefault();
                monhocs.ID = monhoc.ID;
                monhocs.IDKhoaBoMon = monhoc.IDKhoaBoMon;
                monhocs.MaMonHoc = monhoc.MaMonHoc;
                monhocs.TenMonHoc = monhoc.TenMonHoc;
                monhocs.HocPhanTienQuyet = monhoc.HocPhanTienQuyet;
                monhocs.HocPhanHocTruoc = monhoc.HocPhanHocTruoc;
                monhocs.SoTiet = monhoc.SoTiet;
                monhocs.SoTietLyThuyet = monhoc.SoTietLyThuyet;
                monhocs.SoTietThucHanh = monhoc.SoTietThucHanh;
                monhocs.LoaiMonHoc = monhoc.LoaiMonHoc;
                monhocs.SoTinChi = monhoc.SoTinChi;
                monhocs.GhiChu = monhoc.GhiChu;

                model.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}