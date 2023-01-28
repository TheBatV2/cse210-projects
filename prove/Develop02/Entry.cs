using System;

public class Entry
{
  public string _date;
  public string _prompt;
  public string _input;

  public void Display()
  {
    Console.WriteLine($"{_date}, {_prompt}:\n {_input}");
    
  }
  

}