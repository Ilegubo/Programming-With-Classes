public class Job
{
    public string _jobTitle;
    public string _company;
    public DateOnly _startDate;
    public DateOnly _endDate;

    public void Display()
    {
        if (!string.IsNullOrEmpty(_jobTitle) &&
        !string.IsNullOrEmpty(_company)&&
        _startDate !=default &&
        _endDate != default)
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startDate.ToString("yyyy")}-{_endDate.ToString("yyyy")}");
        }
    }
}