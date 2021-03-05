using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title  { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime date { get; set; }
    public int Id { get; }
    public static List<Order> _instances = new List<Order> { };

    public Order (string title, string description, int price)
    {
      Title = title;
      Description = description;
      Price = price; 
    }

    public static List <Order> GetAll()
    {
      return _instances;
    }
  }
}