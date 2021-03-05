using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void
    OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {

      string title01 = "Bread"; 
      string title02 = "Pastry";
      string description01 = "Delicious";
      string description02 = "Yummy";
      int price01 = 1;
      int price02 = 1;
      Order newOrder1 = new Order(title01, description01, price01);
      Order newOrder2 = new Order(title02, description02, price02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Bread";
      string description = "Delicious";
      int price = 1;
      Order newOrder = new Order(title, description, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Bread";
      string title02 = "Pastry";
      string description01 = "Delicious";
      string description02 = "Yummy";
      int price01 = 1;
      int price02 = 2;
      Order newOrder1 = new Order(title01, description01, price01);
      Order newOrder2 = new Order(title02, description02, price02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}