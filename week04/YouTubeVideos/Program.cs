using System;
using System.Collections;
namespace YoutubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\n");
        List<Video> listOfVideos = new List<Video>();
        
        Video macBookNeo = new Video("The new Mac Full review","MKBHD", 350);
        
        Video generalConference =
            new Video();
        generalConference.SetAuthor("The Church Afternoon Session");
        generalConference.SetLength(745);
        generalConference.SetTitle("Sunday Afternoon Session");
        Video musicAndTheSpokenWord = new Video("Music and The Spoken Word",
            "The Church of Jesus Christ of Latter-day Saints", 120);

        Video elClasicoHighlights = new Video("El Clasico Highlists", "Bernabéu HQ", 300);
        
        macBookNeo.AddComment("user1","great affordable product");
        macBookNeo.AddComment("user2","this is supposed to be affordable but it's not for me.");
        macBookNeo.AddComment("user3","Just get the air or if you can afford to, get the pro.");
        
        generalConference.AddComment("user1", "really inspiring messages");
        generalConference.AddComment("user2", "I loved the music");
        generalConference.AddComment("user3", "We have a living prophet");
        
        listOfVideos.Add(macBookNeo);
        listOfVideos.Add(generalConference);
        
        DisplayVideos(listOfVideos);
    }

    public static void DisplayVideos(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()} | Length: {video.GetLength()}s");
            List<Comment> comments = video.GetComments();
            Console.WriteLine("*------------------Comments------------------*");
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"Author: {comment.GetName()} | Text: {comment.GetText()}");
            }
            Console.WriteLine("*--------------------------------------------*\n\n");
        }
    }
}