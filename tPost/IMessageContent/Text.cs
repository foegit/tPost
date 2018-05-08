using System;
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

        public async void Send(TelegramMessage msg)
        {
            
            try
            {
                //@return = msg.Bot.SendTextMessageAsync(msg.CanalName, msg.Text, ParsingMode, DisablePagePrewiew, msg.Notification).ToString();
                
                await msg.Bot.SendTextMessageAsync(msg.CanalName, msg.Text, ParsingMode, DisablePagePrewiew, msg.Notification);
                
            }


            catch (Exception e)
            {
                MessageBox.Show($"Случилась ошибка!\n {e.Message}");
            }
            
        }
    }
}