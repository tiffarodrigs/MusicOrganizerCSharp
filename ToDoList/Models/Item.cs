using System;
using System.Collections.Generic;
namespace ToDoList.Models
{
  public class Item
  {

    // properties, methods, etc. will go here.
    //Create Dresription property,and field _instance which is list of item object
    //Create item constuctor which has set the description and add the this item object to List
    //Cgreat a get method to get the list of itm obj
    //create a clearAll method to clear previous item objectt 
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public Item(string description)
    {
      Description = description;
      _instances.Add(this); // New code.
    }
    public static List<Item> GetAll()
    {
    return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}