using System;

class DisplayScripture
{
    public string _scripture;
        
    //sets a list to pull from to not overlap words.
    private List<string> blankedScripture = new List<string> {};

    public DisplayScripture(string originalScripture)
    {
        _scripture = originalScripture;
        List<string> convertvar = _scripture.Split("").ToList();
        for (int i = 0; i <convertvar.Count(); i++)
        {
            blankedScripture.Add(convertvar[i]);
            //Console.WriteLine(i);
        }

    }

    public void Display()
    {
        Scripture referance = new Scripture();
        // calls referance for display
        string referance1 = referance.getReferance();
        //gets random number to replace word with Blanks
        int r1 = getMemorizer();
        int r2 = getMemorizer();
        int r3 = getMemorizer();
        Console.WriteLine($"{blankedScripture[r1]}");
        // Word word1 = new Word(r1);
        // Word word2 = new Word(r2);
        // Word word3 = new Word(r3);
        // string randomWordBlank = word.getUnderscore();
        // blankedScripture[blankedScripture.IndexOf(randomWord)].Replace($"{randomWord}",$"{randomWordBlank}");
        // string finalScripture = string.Join("", blankedScripture);
        // Console.WriteLine($"{referance1}: {finalScripture}");
        

    }

    
    private int getMemorizer()
    {
        Random randomNumber = new Random();
        int random = randomNumber.Next(0, blankedScripture.Count);
        //Console.WriteLine($"{blankedScripture[random]}");
        //return blankedScripture[random];
        return random;
    }
 
    
}
