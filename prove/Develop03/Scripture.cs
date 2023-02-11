using System;

class Scripture
{
    private string referance = "Moroni 10:5";
    // And by the power of the holy ghost ye may know the truth of all things  Moroni 10:5

    private List<string> scripture = new List<string> {"And ", "by ", "the ", "power ", "of ", "the ", "Holy ", "Ghost ", "ye ", "may ", "know ", "the ", "truth ", "of ", "all ", "things "};



    public string getScripture()
    {
       string variScripture = string.Join("", scripture);
       return variScripture;
    }

    public string getReferance()
    {
        string refer = referance;
        return refer;
    }

    // public void getFirstScripture()
    // {
       
    
    //    for(int i=0; i<scripture.Count; i++)
    //    {
    //     Console.WriteLine(scripture[i]);
    //    }
    
    // }
}