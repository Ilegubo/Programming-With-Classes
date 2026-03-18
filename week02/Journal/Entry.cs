class Entry
{
    string _entry;
    void journalEntry(string content, string prompt)
    {
        string today = DateTime.Today.ToString("dd/MM/yyyy");
        _entry = $"{today}\n{prompt}\n{content}";
    }
}