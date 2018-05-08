namespace tPost.IMessageContent
{
    public interface IMessageContent
    {
        int TextMaxLength { get; }
        void  Send(TelegramMessage msg);
    }
}