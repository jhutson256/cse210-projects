using System;

public class Reference
{
    private string _jphBook;
    private int _jphChapter;
    private int _jphStart;
    private int _jphEnd;

    public Reference()
    {
        _jphBook = "";
        _jphChapter = 0;
        _jphStart = 0;
        _jphEnd = 0;
    }

    public Reference(string jph_book, int jph_chapter, int jph_verse)
    {
        _jphBook = jph_book;
        _jphChapter = jph_chapter;
        _jphStart = jph_verse;
    }

    public Reference(string jph_book, int jph_chapter, int jph_start, int jph_end)
    {
        _jphBook = jph_book;
        _jphChapter = jph_chapter;
        _jphStart = jph_start;
        _jphEnd = jph_end;
    }

    public override string ToString()
    {
        if (_jphEnd != 0)
        {
            return $"{_jphBook}" + " " + $"{_jphChapter}" + ":" + $"{_jphStart}" + "-" + $"{_jphEnd}";
        }
        else
        {
            return $"{_jphBook}" + " " + $"{_jphChapter}" + ":" + $"{_jphStart}";
        }
    }
}