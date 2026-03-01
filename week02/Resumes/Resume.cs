public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        if (!string.IsNullOrEmpty(_name)&&
        _jobs.Any())
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("\nJobs:");
            
            foreach(Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}