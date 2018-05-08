using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using tPost.IMessageContent;
namespace tPost
{
    public abstract class TelegramMessage
    {
        public TelegramBotClient Bot { get; set; }
        public string CanalName { get; set; }
        public string Text { get; set; }
        public int MaxLenth => Content.TextMaxLength;
        public bool Notification { get; set; }
        public IMessageContent.IMessageContent Content;

        protected TelegramMessage()
        {
            Bot = new TelegramBotClient(Settings.Default.BotToken);
            CanalName = Settings.Default.CanalID;
            Text = "";
            Notification = true;

        }

        public async Task<Telegram.Bot.Types.Message> Send()
        {
                return await Content.Send(this);
        }






    }
}