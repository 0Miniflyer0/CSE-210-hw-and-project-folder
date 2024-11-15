public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public string Display()
    {
        return _isHidden ? "____" : _text;
    }
    public bool IsHidden() => _isHidden;
}
