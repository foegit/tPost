using System;
using System.Threading.Tasks;

namespace tPost.IMessageContent
{
    public interface IMessageContent:ICloneable
    {
        int TextMaxLength { get; }
        Task<string> Send(TelegramMessage msg);
    }
}