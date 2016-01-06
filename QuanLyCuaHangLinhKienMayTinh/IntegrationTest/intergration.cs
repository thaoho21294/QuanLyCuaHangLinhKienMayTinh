using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL.Warehouse;

namespace IntegrationTest
{
    [TestFixture]
    public class intergration
    {
        DalProduct product = new DalProduct();
        /// Thêm sản phẩm với mã sản phẩm mới, kiểm tra cơ sở dữ liệu có thay đổi
        [Test]
        public void AddProduct1()
        {
            int expected1 = product.GetListProducts().Rows.Count + 1;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP127", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);

            actual1 = product.GetListProducts().Rows.Count;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);
            product.DeleteProduct(dto.MaSanPham);

        }

        /// Xóa sản phẩm, sau đó thêm lại
        [Test]
        public void AddProduct2()
        {
            int expected1 = product.GetListProducts().Rows.Count;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected0 = 1;
            int actual0 = product.DeleteProduct(dto.MaSanPham);

            int expected = 1;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);

            actual1 = product.GetListProducts().Rows.Count;

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);
        }

        /// Xóa sản phẩm chưa tồn tại trong bảng, sau đó thêm lại
        [Test]
        public void AddProduct3()
        {
            int expected1 = product.GetListProducts().Rows.Count + 1;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1123", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected0 = 0;
            int actual0 = product.DeleteProduct(dto.MaSanPham);

            int expected = 1;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);

            actual1 = product.GetListProducts().Rows.Count;

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);

            product.DeleteProduct(dto.MaSanPham);
        }

        /// Thêm sản phẩm với mã sản phẩm bị trùng
        [Test]
        public void AddProduct4()
        {
            int expected1 = product.GetListProducts().Rows.Count;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);

            actual1 = product.GetListProducts().Rows.Count;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);
        }

        ///KIểm tra sửa sản phẩm có đúng với cơ sở dữ liệu
       [Test]
        public void EditProduct1()
        {
            int expected1 = 90;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP4", "USB Tosiba", "Phụ kiện", 90, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.EditProduct(dto);

            actual1 = product.GetProductByID(dto.MaSanPham).ThoiGianBaoHanh;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);

            dto.ThoiGianBaoHanh = 60;
            product.EditProduct(dto);
        }

        ///KIểm tra sửa sản phẩm với ID không tồn tại trong cơ sở dữ liệu
        [Test]
        public void EditProduct2()
        {
            int expected1 = 0;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP234234", "USB Tosiba", "Phụ kiện", 90, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.EditProduct(dto);

            actual1 = product.GetProductByID(dto.MaSanPham).ThoiGianBaoHanh;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);

            dto.ThoiGianBaoHanh = 60;
            product.EditProduct(dto);
        }

        /// <summary>
        ///  Xóa rồi sau đó sửa
        /// </summary>
        [Test]
        public void EditProduct3()
        {
            int expected1 = 0;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.DeleteProduct(dto.MaSanPham);
            Assert.AreEqual(expected, actual);

            actual1 = product.EditProduct(dto);

            Assert.AreEqual(actual1, expected1);

            product.AddProduct(dto);
        }


        /// Thêm xong xóa
        [Test]
        public void DeleteProduct1()
        {
            int expected1 = product.GetListProducts().Rows.Count;
            int actual1 = 0;

            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP112312", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.AddProduct(dto);

            int expected0 = 1;
            int actual0 = product.DeleteProduct(dto.MaSanPham);



            actual1 = product.GetListProducts().Rows.Count;

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual1, expected1);
        }



    }
}
