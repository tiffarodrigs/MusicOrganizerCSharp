using System;
using System.Collections.Generic;
namespace MusicOrganizer.Models
{
  public class Record
  {

    // properties, methods, etc. will go here.
    //Create Dresription property,and field _instance which is list of item object
    //Create item constuctor which has set the description and add the this item object to List
    //Cgreat a get method to get the list of itm obj
    //create a clearAll method to clear previous item objectt 
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _instances = new List<Record> {};
    public Record(string title)
    
    {
      Title = title;
      _instances.Add(this); // New code.
      Id = _instances.Count;
    }
    public static List<Record> GetAll()
    {
    return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Record Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}