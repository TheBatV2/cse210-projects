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
            blankedScripture = convertvar;
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
        string word1 = blankedScripture[r1];
        string word2 = blankedScripture[r2];
        string word3 = blankedScripture[r3];
        Word word1Blank = new Word(word1);
        string randomWordBlank1 = word1Blank.getUnderscore(word1);
        Word word2Blank = new Word(word2);
        string randomWordBlank2 = word2Blank.getUnderscore(word2);
        Word word3Blank = new Word(word3);
        string randomWordBlank3 = word3Blank.getUnderscore(word3);
        blankedScripture[r1].Replace($"{blankedScripture[r1]}",$"{randomWordBlank1}");
        blankedScripture[r2].Replace($"{blankedScripture[r2]}",$"{randomWordBlank2}");
        blankedScripture[r3].Replace($"{blankedScripture[r3]}",$"{randomWordBlank3}");
        string finalScripture = string.Join("", blankedScripture);
        Console.WriteLine($"{referance1}: {finalScripture}");
        

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
