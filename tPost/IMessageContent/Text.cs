using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;

namespace tPost.IMessageContent
{
    public class Text : IMessageContent
    {
        public ParseMode ParsingMode { get; set; }
        public bool DisablePagePrewiew;
        public int TextMaxLength { get; }

        public Text()
        {
            TextMaxLength = 4096;
            ParsingMode = ParseMode.Default;
            DisablePagePrewiew = !Settings.Default.PagePreview;
        }

        public async Task<Telegram.Bot.Types.Message> Send(TelegramMessage msg)
        {
                var res = await msg.Bot.SendTextMessageAsync(msg.CanalName, msg.Text, ParsingMode, DisablePagePrewiew, msg.DisapleNotification);
                MessageBox.Show(@"Сообщения успешно отпралено!");
                return res;
        }
    }
}