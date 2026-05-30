using System;

public class Scripture
{
    private Passage _jphPassage;
    private Reference _jphReference;

    public Scripture()
    {
        _jphPassage = new Passage();
        _jphReference = new Reference();
    }

    public Scripture(Reference jph_reference, Passage jph_passage)
    {
        _jphReference = jph_reference;
        _jphPassage = jph_passage;
    }

    public void HideWords(int jph_count)
    {
        _jphPassage.HideRandomWords(jph_count);
    }

    public override string ToString()
    {
        return $"{_jphReference}" + " " + "-" + " " + $"{_jphPassage}";
    }
}