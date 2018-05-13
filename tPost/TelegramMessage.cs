using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using tPost.IMessageContent;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace tPost
{
    public class TelegramMessage : ICloneable
    {
        public TelegramBotClient Bot { get; set; }
        public string CanalName { get; set; }
        public string Text { get; set; }
        public int MaxLenth => Content.TextMaxLength;
        public bool DisableNotification { get; set; }
        public IMessageContent.IMessageContent Content;
        public InlineKeyboardMarkup InlineMarkup;
        public DateTime PublicationDate;
        public bool IsTimedMsg;
        public ListUBPanel UbPanels;



        public TelegramMessage()
        {
            IsTimedMsg = false;
            PublicationDate = new DateTime();

            UbPanels = new ListUBPanel();
            Bot = new TelegramBotClient(Settings.Default.BotToken);
            CanalName = Settings.Default.CanalID;
            Text = "";
            DisableNotification = !Settings.Default.Notification;
            Content = new SimpleText();
            InlineMarkup = null;

        }


        

        public async Task<string> Send()
        {

            InlineMarkup = null;
            if (UbPanels.Count != 0)
            {
                InlineMarkup = new InlineKeyboardMarkup();
                InlineKeyboardButton[][] array = new InlineKeyboardButton[UbPanels.Count][];
                for (int i = 0; i < UbPanels.Count; i++)
                {
                    array[i] = new InlineKeyboardButton[1];
                    array[i][0] = new InlineKeyboardUrlButton(UbPanels[i].UbData.Name, UbPanels[i].UbData.Address);
                }
                InlineMarkup = new InlineKeyboardMarkup(array);
            }

            var result = await Content.Send(this);
            return result;

            
        }

        public void AddUrlButton(string title, string url)
        {
            
            UbPanels.Add(new UBPanel(title,url));

        }

        public object Clone()
        {
            var cloneMessage = new TelegramMessage();
            cloneMessage.Text = Text;
            cloneMessage.Bot = Bot;
            cloneMessage.CanalName = CanalName;
            cloneMessage.DisableNotification = DisableNotification;
            cloneMessage.Content = (IMessageContent.IMessageContent)Content.Clone();
            
            return cloneMessage;
        }
    }
}