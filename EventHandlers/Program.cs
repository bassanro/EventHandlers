namespace EventHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); // Subscriber

            // No change was required when we add Another Subscriber.
            var messageService = new MessageService(); //Subscriber

            // Add delegate to event
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageService.onVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
