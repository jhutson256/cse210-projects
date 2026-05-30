using System;
// 1. Gemini code advice

public class Passage
{
    private List<Word> _jphPassage = new List<Word>();

    public Passage()
    {
        _jphPassage = [];
    }

    public void AddWord(Word jph_word)
    {
        _jphPassage.Add(jph_word);
    }

    public override string ToString()
    {
        return string.Join(" ", _jphPassage);
    }

    public void HideRandomWords(int jph_count)
    {
        Random jph_random = new Random();
        int hiddenCount = 0; // 1.
        int visibleWordsCount = _jphPassage.Count(w => !w.IsHidden()); // 1.

        if (jph_count > visibleWordsCount) // 1.
        {
            jph_count = visibleWordsCount; // 1.
        }

        while (hiddenCount < jph_count)
        {
            int jph_INDEX = jph_random.Next(_jphPassage.Count);
            
            if (!_jphPassage[jph_INDEX].IsHidden()) 
            {
                _jphPassage[jph_INDEX].Hide();
                hiddenCount++; // 1.
            }
        }
    }
}