using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using tPost.IMessageContent;
namespace tPost
{
    public class TelegramMessage
    {
        public TelegramBotClient Bot { get; set; }
        public string CanalName { get; set; }
        public string Text { get; set; }
        public int MaxLenth => Content.TextMaxLength;
        public bool DisableNotification { get; set; }
        public IMessageContent.IMessageContent Content;

       public TelegramMessage()
        {
            Bot = new TelegramBotClient(Settings.Default.BotToken);
            CanalName = Settings.Default.CanalID;
            Text = "";
            DisableNotification = !Settings.Default.Notification;
            Content = new SimpleText();
        }

        public async Task<Telegram.Bot.Types.Message> Send()
        {
                return await Content.Send(this);
        }






    }
}