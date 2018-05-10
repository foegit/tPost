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
    public class TelegramMessage
    {
        public TelegramBotClient Bot { get; set; }
        public string CanalName { get; set; }
        public string Text { get; set; }
        public int MaxLenth => Content.TextMaxLength;
        public bool DisableNotification { get; set; }
        public IMessageContent.IMessageContent Content;
        public InlineKeyboardMarkup InlineMarkup;

        public ListUBPanel UbPanels;

        public List<UrlButtonData> urlButtons;

        public TelegramMessage()
        {
            UbPanels= new ListUBPanel();
            Bot = new TelegramBotClient(Settings.Default.BotToken);
            CanalName = Settings.Default.CanalID;
            Text = "";
            DisableNotification = !Settings.Default.Notification;
            Content = new SimpleText();
            InlineMarkup = null;

        }

        public async Task<Telegram.Bot.Types.Message> Send()
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
            return await Content.Send(this);
        }

        public void AddUrlButton(string title, string url)
        {
            
            UbPanels.Add(new UBPanel(title,url));

        }

    }
}