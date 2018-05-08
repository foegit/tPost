using System.Threading.Tasks;

namespace tPost.IMessageContent
{
    public interface IMessageContent
    {
        int TextMaxLength { get; }
        Task<Telegram.Bot.Types.Message> Send(TelegramMessage msg);
    }
}