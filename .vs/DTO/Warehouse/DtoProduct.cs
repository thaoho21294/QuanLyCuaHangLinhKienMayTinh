using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace DTO.Warehouse
{
    public class DtoProduct
    {
        private string _maSanPham;
        private string _tenSanPham;
        private string _loaiSanPham;
        private int _thoiGianBaoHanh;
        private double _donGiaNhap;
        private double _donGiaBan;
        private int _soLuong;
        private string _donViTinh;
        private string _ghiChu;


        public DtoProduct()
        {

        }


        public DtoProduct(string maSanPham,
            string tenSanPham,
            string loaiSanPham,
            int thoiGianBaoHanh,
            double donGiaNhap,
            double donGiaBan,
            int soLuong,
            string donViTinh,
            string ghiChu)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            LoaiSanPham = loaiSanPham;
            ThoiGianBaoHanh = thoiGianBaoHanh;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            SoLuong = soLuong;
            DonViTinh = donViTinh;
            GhiChu = ghiChu;
        }

        public string MaSanPham
        {
            get { return _maSanPham; }
            set
            {
                
                    _maSanPham = value;
                
            }
        }

        public string TenSanPham
        {
            get { return _tenSanPham; }
            set
            {
                
                    _tenSanPham = value;
                
            }
        }

        public double DonGiaNhap
        {
            get { return _donGiaNhap; }
            set
            {
                
                    _donGiaNhap = value;
                
            }
        }

        public double DonGiaBan
        {
            get { return _donGiaBan; }
            set
            {
                
                    _donGiaBan = value;
                
            }
        }

        public string DonViTinh
        {
            get { return _donViTinh; }
            set
            {
                
                    _donViTinh = value;
                
            }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set
            {
                
                    _ghiChu = value;
                
            }
        }

        public string LoaiSanPham
        {
            get { return _loaiSanPham; }
            set
            {
                 
                    _loaiSanPham = value;
                 
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                 
                    _soLuong = value;
                 
            }
        }

        public int ThoiGianBaoHanh
        {
            get { return _thoiGianBaoHanh; }
            set
            {
                 
                    _thoiGianBaoHanh = value;
                 
            }
        }

        public override string ToString()
        {
            return $"ThoiGianBaoHanh: {ThoiGianBaoHanh}, SoLuong: {SoLuong}, LoaiSanPham: {LoaiSanPham}, GhiChu: {GhiChu}, DonViTinh: {DonViTinh}, DonGiaBan: {DonGiaBan}, DonGiaNhap: {DonGiaNhap}, TenSanPham: {TenSanPham}, MaSanPham: {MaSanPham}";
        }

        public override bool Equals(object obj)
        {
            DtoProduct _obj = (DtoProduct)obj;
            if (_obj.MaSanPham == MaSanPham && _obj.LoaiSanPham == LoaiSanPham && _obj.GhiChu == GhiChu && _obj.DonViTinh == DonViTinh
                && _obj.DonGiaNhap == DonGiaNhap && _obj.DonGiaBan == DonGiaBan && _obj.SoLuong == SoLuong && _obj.TenSanPham == TenSanPham && _obj.ThoiGianBaoHanh == ThoiGianBaoHanh)
                return true;
            return false;
 
                
        }

    }
}
