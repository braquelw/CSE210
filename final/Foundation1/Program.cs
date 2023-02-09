using System;

class Program
{
    static void Main(string[] args)
    {
        AllVideos allVideos = new AllVideos();
        Console.Clear();

        // Video1 Comments
        Comment comment1 = new Comment();
        comment1._commenterName = "Dallin Candland";
        comment1._commentText = "So thankful for the words of living prophets and apostles.";

        Comment comment2 = new Comment();
        comment2._commenterName = "adriana del barrio";
        comment2._commentText = "Great talk!";

        Comment comment3 = new Comment();
        comment3._commenterName = "Belle Gay";
        comment3._commentText = "Thank you so much for this wonderful message.";

        Comment comment4 = new Comment();
        comment4._commenterName = "Vicky Kawaguchi";
        comment4._commentText = "I love this talk, it gives me hope. I listen to it often.";

        // Video1 Information
        Video video1 = new Video();
        video1._title = "God Will Do Something Unimaginable";
        video1._author = "Dieter F. Uchtdorf";
        video1._length = 917;
        
        // Add Comments to Video1
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);

        // Add Video1 to List
        allVideos._videos.Add(video1);

        
        // Video2 Comments
        Comment comment5 = new Comment();
        comment5._commenterName = "Mbali Mchunu";
        comment5._commentText = "God is never too early or too late. He is always on time.";

        Comment comment6 = new Comment();
        comment6._commenterName = "Lindy Lu";
        comment6._commentText = "This is THE message I needed.";

        Comment comment7 = new Comment();
        comment7._commenterName = "Nathan Banks";
        comment7._commentText = "God's love for each of us is so powerful!";

        // Video2 Information
        Video video2 = new Video();
        video2._title = "Our Relationship with God";
        video2._author = "D. Todd Christofferson";
        video2._length = 797;
        
        // Add Comments to Video2
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);

        // Add Video2 to List
        allVideos._videos.Add(video2);
        
        
        // Video3 Comments
        Comment comment8 = new Comment();
        comment8._commenterName = "Jennifer Howard";
        comment8._commentText = "I have never felt a conference talk so strongly!";

        Comment comment9 = new Comment();
        comment9._commenterName = "Cami P";
        comment9._commentText = "President Nelson, thank you very much! We love and sustain you!";

        Comment comment10 = new Comment();
        comment10._commenterName = "Shannon Jensen";
        comment10._commentText = "This one feels like a personal blessing.";

        Comment comment11 = new Comment();
        comment11._commenterName = "Linda Petchford";
        comment11._commentText = "Thank you for being our prophet.";

        // Video3 Information
        Video video3 = new Video();
        video3._title = "Overcome the World and Find Rest";
        video3._author = "Russell M. Nelson";
        video3._length = 1123;
        
        // Add Comments to Video3
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);

        // Add Video3 to List
        allVideos._videos.Add(video3);


        allVideos.DisplayVideos();
    }
}