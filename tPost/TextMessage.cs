using System;
using tPost.IMessageContent;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace tPost
{
    public class TextMessage : TelegramMessage
    {

        public TextMessage()
        {
            Content = new SimpleText();

        }

        

    }
}