using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;
using DAL.Warehouse;

namespace UniTest
{
    // Layer DAL
    [TestFixture]
    public class DalProductTest
    {
        DalProduct product = new DalProduct();
        // GetListProducts -false
        [Test]
        public void GetListProductsTest1()
        {
            Assert.IsNotNull(product.GetListProducts());
        }

        // getProductByID -true
        [Test]
        public void GetProductByID1()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Tosiba", "Phụ kiện", 60,100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = true;
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, dto.Equals(actual));
        }
        [Test]
        public void GetProductByID2()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Toaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = false;
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected,dto.Equals(actual));
        }
        [Test]
        public void GetProductByID3()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP871", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = false;
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected,dto.Equals(actual));
        }

        //AddProduct - test insert true or false
        [Test]
        public void AddProduct1()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP127", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);
            
            //delete
            product.DeleteProduct(dto.MaSanPham);
        }
        [Test]
        public void AddProduct2()
        {


            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP46", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            Console.WriteLine(dto.ToString());
            int expected = 0;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);

 
        }
        [Test]
        public void AddProduct3()
        {


            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP497", "USB Tofffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffsiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            Console.WriteLine(dto.ToString());
            int expected = 0;
            int actual = product.AddProduct(dto);
            Assert.AreEqual(expected, actual);


        }
        //AddProduct - test insert data correct in  SQL
        [Test]
        public void AddProduct4()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP12", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = true;
            product.AddProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));

            //delete
            product.DeleteProduct(dto.MaSanPham);
        }
        [Test]
        public void AddProduct5()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP45", "USB Tosiba", "Phụ", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = true;
            product.AddProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));

            //delete
            product.DeleteProduct(dto.MaSanPham);
        }
        [Test]
        public void AddProduct6()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP152", "USBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected =false;
            product.AddProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));

            //delete
            product.DeleteProduct(dto.MaSanPham);
        }


        //EditProduct- test edit  true or false
        [Test]
        public void EditProduct1()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP4", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.EditProduct(dto);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void EditProduct2()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP097", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.EditProduct(dto);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void EditProduct3()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP097", "USBffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffTosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.EditProduct(dto);
            Assert.AreEqual(expected, actual);
        }
        //EditProduct- test edit data correct in  SQL
        [Test]
        public void EditProduct4()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP5", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = true;
            product.EditProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));

        }
        [Test]
        public void EditProduct5()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP8", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = false;
            product.EditProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));
        }
        [Test]
        public void EditProduct6()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP7", "USBffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffTosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            bool expected = false;
            product.EditProduct(dto);
            DTO.Warehouse.DtoProduct actual = product.GetProductByID(dto.MaSanPham);
            Assert.AreEqual(expected, actual.Equals(dto));
        }

        //DeleteProduct-test delete  true or false
        [Test]
        public void DeleteProduct1()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP1", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 1;
            int actual = product.DeleteProduct(dto.MaSanPham);
            Assert.AreEqual(expected, actual);
            product.AddProduct(dto);
        }
        [Test]
        public void DeleteProduct2()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP565", "USB Tosiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.DeleteProduct(dto.MaSanPham);
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void DeleteProduct3()
        {
            DTO.Warehouse.DtoProduct dto = new DTO.Warehouse.DtoProduct("SP35", "USB Tosffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffiba", "Phụ kiện", 60, 100000.0000, 150000.0000, 20, "cái", "Hàng Trung Qu?c");
            int expected = 0;
            int actual = product.DeleteProduct(dto.MaSanPham);
            Assert.AreEqual(expected, actual);


        }

         



    }
}
