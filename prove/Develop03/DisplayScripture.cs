using System;

class DisplayScripture
{
    public string _scripture;
        
    //sets a list to pull from to not overlap words.
    private List<string> blankedScripture = new List<string> {};

    public DisplayScripture(string originalScripture)
    {
        _scripture = originalScripture;
        List<string> convertvar = new List<string>(_scripture.Split(""));
        foreach(string i in convertvar)
        {
            blankedScripture.Add(i);
            //Console.WriteLine(i);
        }

    }

    public void Display()
    {
        Scripture referance = new Scripture();
        string referance1 = referance.getReferance();
        string randomWord = getMemorizer();
        Word word = new Word(randomWord);
        string randomWordBlank = word.getUnderscore();
        blankedScripture[blankedScripture.IndexOf(randomWord)].Replace($"{randomWord}",$"{randomWordBlank}");
        string finalScripture = string.Join("", blankedScripture);
        Console.WriteLine($"{referance1}: {finalScripture}");
        

    }

    
    private string getMemorizer()
    {
        Random randomNumber = new Random();
        int random = randomNumber.Next(0, blankedScripture.Count);
        Console.WriteLine($"{blankedScripture[random]}");
        return blankedScripture[random];
    }
 
    
}
