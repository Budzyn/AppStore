using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppStore.Domain.Entities;

namespace AppStore.UnitTests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void Calculate_Cart_Total()
        {
            //Arrange
            Product p1 = new Product { ProductID = 1, Name = "P1", Price=100M};
            Product p2 = new Product { ProductID = 2, Name = "P2", Price=50M };
            Cart target = new Cart();
           
            //Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            decimal result=target.ComputeTotalValue();
            //Assert
            Assert.AreEqual(result, 150M);
        }
    }
}
