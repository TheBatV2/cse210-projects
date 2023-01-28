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

  public string formatEntry()
  {
    return ($"{_date} ~~ {_prompt}: ~~ {_input}");
  }

  public Entry(string date, string prompt, string userInput)
  {
    _date = date;
    _prompt = prompt;
    _input = userInput;
  }
  

  

}