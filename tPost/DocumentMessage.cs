using tPost.IMessageContent;

namespace tPost
{
    public class DocumentMessage:TelegramMessage
    {
        public DocumentMessage()
        {
            Content = new Document();
        }
        public DocumentMessage(string filePath)
        {
            Content = new Document(filePath);
        }

    }
}