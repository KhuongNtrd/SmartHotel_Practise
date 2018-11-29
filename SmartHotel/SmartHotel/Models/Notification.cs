using System;

namespace SmartHotel.Models
{
    public class Notification
    {
        public int Seq { get; set; }

        public string Text { get; set; }

        public DateTime Time { get; set; }

        public NotificationType Type { get; set; }
    }
}