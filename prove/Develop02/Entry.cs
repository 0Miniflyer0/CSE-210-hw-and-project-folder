using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public void SetResponse(string response)
    {
        _response = response;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public override string ToString()
    {
        return $"{_date.ToShortDateString()} - {_prompt}\n{_response}\n";
    }
}
