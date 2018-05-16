using System;

namespace tPost
{
    public class PostponedTelegramMessage : ICloneable
    {
        public TelegramMessage Message;
        public DateTime Time;
        public bool Validation;
        public bool IsSend;
        
        public PostponedTelegramMessage(TelegramMessage message, DateTime time)
        {
            Message = message;
            Time = time;
            Validation = true;
            IsSend = false;

        }

        public async void Check()
        {
            try
            {
               await Message.Send();
               Validation = true;
            }
            catch (Exception e)
            {
                Validation = false;
                
            }
        }

        public object Clone()
        {
            return new PostponedTelegramMessage((TelegramMessage)Message.Clone(), new DateTime(Time.Year,Time.Month,Time.Day,Time.Hour,Time.Minute,Time.Second,Time.Millisecond,Time.Kind));
        }

        public void Set(DateTime time)
        {
            Time = time;
        }

        public void Set(TelegramMessage message)
        {
            Message = message;
        }

        public void Set(TelegramMessage message, DateTime time)
        {
            Message = message;
            Time = time;
        }

    }
}