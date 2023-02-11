using System;

class Word
{
    
   Word w = new Word();
    w._text = "temple";
    w._isHidden = False;
    // We could create a GetDisplayText() method to return what we want.
    Console.WriteLine(w.GetDisplayText()); // Displays "temple"
    w._isHidden = True;
    // Now the method should return "______"
    Console.WriteLine(w.GetDisplayText()); // Displays "______"
}