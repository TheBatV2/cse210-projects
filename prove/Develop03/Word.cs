using System;

class Word
{
    // gets word, replaces word for blank spaces, returns word
    private string _randomWord;

    public Word(string randomWord)
    {
        _randomWord = randomWord;
    }

    public string getUnderscore(string word)
    {

        int digit = word.Count();
        string underscore = "_";
        _randomWord = _randomWord.Replace($"{_randomWord}", $"{underscore[digit]}");
        return _randomWord;
    }


}