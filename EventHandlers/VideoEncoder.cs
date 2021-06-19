using System;
using System.Threading;

namespace EventHandlers
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Define an event based on that delegate 
        //3 -Raise an event
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        // EventHandler
        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            onVideoEncoded(video);
        }

        //Notify subscriber 
        protected virtual void onVideoEncoded(Video video)
        {
            if (VideoEncoded != null) // Check if there are any subscribers registered. 
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
