using System;

public class Reference
{
    private string _book;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = null;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetBook() => _book;
    public int GetStartVerse() => _startVerse;
    public int? GetEndVerse() => _endVerse;
    public override string ToString()
    {
        return _endVerse.HasValue ? $"{_book} {_startVerse}-{_endVerse}" : $"{_book} {_startVerse}";
    }
}
