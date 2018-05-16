using System;

using System.Threading.Tasks;

using Telegram.Bot;

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
        public ListUBPanel UbPanels;



        public TelegramMessage()
        {
  
            UbPanels = new ListUBPanel();
            Bot = new TelegramBotClient(Properties.Settings.Default.BotToken);
            CanalName = Properties.Settings.Default.CanalID;
            Text = "";
            DisableNotification = Properties.Settings.Default.DisableNotification;
            Content = new SimpleText();
            InlineMarkup = null;

        }


        

        public async Task<string> Send()
        {
            InlineMarkup = ConstructUrlButtonMarkup();
            return await Content.Send(this);
        }


        public InlineKeyboardMarkup ConstructUrlButtonMarkup()
        {


            var inlineMarkup = new InlineKeyboardMarkup();
            if (UbPanels.Count != 0)
            {
                InlineKeyboardButton[][] array = new InlineKeyboardButton[UbPanels.Count][];
                for (int i = 0; i < UbPanels.Count; i++)
                {
                    array[i] = new InlineKeyboardButton[1];
                    array[i][0] = new InlineKeyboardUrlButton(UbPanels[i].UbData.Name, UbPanels[i].UbData.Address);
                }
                InlineMarkup = new InlineKeyboardMarkup(array);
            }
            else
            {
                return null;
            }

            return inlineMarkup;
        }

        public void AddInlineUrlButton(string title, string url)
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
            cloneMessage.InlineMarkup = ConstructUrlButtonMarkup();
            
            return cloneMessage;
        }
    }
}