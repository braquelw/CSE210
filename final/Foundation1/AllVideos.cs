using System;


class AllVideos{
    public List<Video> _videos = new List<Video>();

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}