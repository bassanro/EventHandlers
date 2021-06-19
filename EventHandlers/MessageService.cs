using System;

namespace EventHandlers
{
    public class MessageService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message.." + e.Video.Title);
        }
    }
}