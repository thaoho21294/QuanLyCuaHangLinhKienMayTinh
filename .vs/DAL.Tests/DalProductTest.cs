// <copyright file="DalProductTest.cs">Copyright ©  2015</copyright>
using System;
using DAL.Warehouse;
using DTO.Warehouse;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Warehouse.Tests
{
    /// <summary>This class contains parameterized unit tests for DalProduct</summary>
    [PexClass(typeof(DalProduct))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DalProductTest
    {
        /// <summary>Test stub for GetProductByID(String)</summary>
        [PexMethod]
        public DtoProduct GetProductByIDTest([PexAssumeUnderTest]DalProduct target, string id)
        {
            DtoProduct result = target.GetProductByID(id);
            return result;
            // TODO: add assertions to method DalProductTest.GetProductByIDTest(DalProduct, String)
        }
    }
}
