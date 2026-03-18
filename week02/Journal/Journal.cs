
class Journal
{
    string _fileName;
    string _fileContent;
    void Display()
    {
        Console.WriteLine(_fileContent);
    }

    bool Load(string fileName)
    {
        try
        {
            _fileContent = System.IO.File.ReadAllText(fileName);
            return true;
        }
        catch (IOException e)
        {
            Console.WriteLine("error 404: file not found.");
            return false;
        }
    }

    bool Save(string fileName)
    {
        try
        {
            System.IO.File.WriteAllText(_fileName, _fileContent);
            return true;
        }
        catch (IOException)
        {
            Console.WriteLine("Error:");
            return false;
        }
    }
}