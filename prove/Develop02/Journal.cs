using System;

public class Journal
{
public List<Entry> _entry = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
        }
    }
}    