using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace tPost.IMessageContent
{
    public class SimpleText : IMessageContent
    {
        public ParseMode ParsingMode { get; set; }
        public bool DisablePagePrewiew;
        public int TextMaxLength { get; }

        public SimpleText()
        {
            TextMaxLength = 4096;
            ParsingMode = ParseMode.Default;
            DisablePagePrewiew = !Settings.Default.PagePreview;


        }
        public void ChangeParseMode(ParseMode parseMode)
        {
            ParsingMode = parseMode;
        }
        public async Task<Telegram.Bot.Types.Message> Send(TelegramMessage msg)
        {
      
            
            var res = await msg.Bot.SendTextMessageAsync(msg.CanalName, msg.Text, ParsingMode, DisablePagePrewiew, msg.DisableNotification, replyMarkup: msg.InlineMarkup);
            
            MessageBox.Show(@"Повідомлення успішно відправлено!");
                return res;
        }

    }
}