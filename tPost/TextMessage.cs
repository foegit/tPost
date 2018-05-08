using System;
using tPost.IMessageContent;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace tPost
{
    public class TextMessage : TelegramMessage
    {
        public ParseMode ParsingMode
        {
            get
            {
                if (Content is Text)
                {
                    return (Content as Text).ParsingMode;
                }
                throw new NullReferenceException();

            }
            set
            {
                if (Content is Text)
                {
                    (Content as Text).ParsingMode = value;
                }
               
            }
        }
        public TextMessage()
        {
            Content = new Text();

        }

        public void ChangeParseMode(ParseMode parseMode)
        {
            ParsingMode = parseMode;
        }

    }
}