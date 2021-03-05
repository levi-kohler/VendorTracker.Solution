using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void
    OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}