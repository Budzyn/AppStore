using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppStore.Domain.Entities;
using AppStore.Domain.Abstract;
using AppStore.WebUI.Controllers;
using Moq;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using AppStore.WebUI.Models;
using AppStore.WebUI.HtmlHelpers;


namespace AppStore.UnitTests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod] 
        public void Index_Contains_All_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]{
                new Product{ProductID=1,Name="P1"},
                new Product{ProductID=2,Name="P2"},
                new Product{ProductID=3,Name="P3"},
            }.AsQueryable());
            AdminController target = new AdminController(mock.Object);
            //Act
            Product p1=target.Edit(1).ViewData.Model as Product;
            Product p2=target.Edit(2).ViewData.Model as Product;
            Product p3=target.Edit(3).ViewData.Model as Product;
            //Assert
            Assert.AreEqual(1, p1.ProductID);
            Assert.AreEqual(2, p2.ProductID);
            Assert.AreEqual(3,p3.ProductID);
        }
    }
}
