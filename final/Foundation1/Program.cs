using System;
using Foundation1.Classes;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("The salt in our cars", "John Verde", 390);
        Video video2 = new Video("A brief history of snails", "S. Carr Gogh", 4339);
        Video video3 = new Video("Down with the cakeriarchy", "Imona Diet", 1935);

        video1.AddComment(
            new Comment(
                "reezergeezer",
                "This was the best video Ive ever seen thank you John Verde!!!!"
            )
        );
        video1.AddComment(
            new Comment("alfalfa_lover", "I didn't understand anything that was going on")
        );
        video1.AddComment(new Comment("KissMeMore69", "yah cuz ur stupid"));
        video1.AddComment(
            new Comment("alfalfa_lover", "shut up you literally can't even talk good")
        );

        video2.AddComment(
            new Comment(
                "snail_enthusiast23",
                "This was really insightful and well-organized. I loved learning about Hardy's Blue Snail!"
            )
        );
        video2.AddComment(
            new Comment(
                "slug_enthusiast32",
                "This was really boring and boring. I loved learning about boringness!"
            )
        );
        video2.AddComment(
            new Comment(
                "salt_enthusiast100",
                "it could have had more gore in it but no, they don't like putting snail guts on a screen. come on guys snails were made to be murdered"
            )
        );

        video3.AddComment(
            new Comment(
                "cakify_me_captain",
                "I'm not sure I agree with everything they say but it's interesting tho"
            )
        );
        video3.AddComment(
            new Comment(
                "IWishIWishIWish",
                "my mom made me a unicorn cake and I ate the WHOLE cake but my brother who is A NOIYING ate the rest of it and i HATE HIM"
            )
        );
        video3.AddComment(
            new Comment(
                "CleanGreenAndVegan420",
                "Preaaaachh woman!!! I love your videos please make another one about how bad eating chicken is :'("
            )
        );

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}