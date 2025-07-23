using System;

    public class Reference
    {
    public string _book { get; set; }
    public int _chapter { get; set; }
    public int _verse { get; set; }
    public int _endVerse { get; set; }

    public Reference(string book, int chapter, int verse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0 || _endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}