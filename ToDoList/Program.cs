using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      //user interface logic
      Console.WriteLine("Welcome to the To Do List");
      RunProgram();
      /*
      if add
      create new obj with description
      if view
      display the list of item object
      */
      
    }

    public static void RunProgram() 
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? add/view");
      string input = Console.ReadLine();
      if(input=="add")
      {
        Console.WriteLine("Enter Description");
        string desc = Console.ReadLine();
        Item item1 = new Item(desc);
      } 
      else if (input == "view") 
      {
        List<Item> toDoList = Item.GetAll();
        int count = 1;
        foreach (Item toDoItem in toDoList) {
          Console.WriteLine((count) + ". " + toDoItem.Description);
          count++;
        }
      } 
      else 
      {
        Console.WriteLine("Please enter in \"add\" or \"view\"");
      }

      Console.WriteLine("Are you finished? y or n");
      string isFinished = Console.ReadLine();
      if (isFinished == "n") 
      { 
        Main();
      } else if (isFinished != "y") 
      {
        Console.WriteLine("You didn't enter in either y or n");
        RunProgram();
      }
    }

  }
}