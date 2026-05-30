using System;
// 1. Gemini code advice

public class Word
{
    private string _jphWord;
    private bool _jphIsHidden;

    public Word()
    {
        _jphWord = "";
        _jphIsHidden = false;
    }

    public Word(string jph_word)
    {
        _jphWord = jph_word;
    }
    
    public override string ToString()
    {
        return _jphIsHidden ? new string('_', _jphWord.Length) : _jphWord; // 1.
    }

    public void Hide() 
    { 
        _jphIsHidden = true; 
    }
    
    public bool IsHidden() 
    { 
        return _jphIsHidden; 
    }
}