using System;
using System.IO;
using System.Threading.Tasks;

using Telegram.Bot.Types;


namespace tPost.IMessageContent
{
    public class Document : IMessageContent
    {
        public int TextMaxLength { get; }

        private FileToSend _documentToSend;
        public long FileSizeInBytes { get; }
        public string FileName;
        private string _filePath;

        public Document()
        {
            TextMaxLength = 201;

        }

        public Document(string filePath) : this()
        {
            _filePath = filePath;
            FileInfo fileInfo = new FileInfo(_filePath);
            FileName = fileInfo.Name;

            FileSizeInBytes = fileInfo.Length;
            
        }





        public async Task<string> Send(TelegramMessage msg)
        {
            
            FileStream fileStream = new FileStream(_filePath, FileMode.Open);

            if (fileStream.CanRead)
            {

                if (FileSizeInBytes <= 52_428_800) // но это не точно
                {
                    _documentToSend = new FileToSend(FileName, fileStream);
                }
                else
                {

                    throw new Exception("Файл не повинен перевищувати 50 мб!");
                }
            }
            else
            {

                throw new FileNotFoundException($"Не знайдено файл!\n{_filePath}");

            }
            await msg.Bot.SendDocumentAsync(msg.CanalName, _documentToSend, msg.Text, msg.DisableNotification, replyMarkup: msg.InlineMarkup);
            fileStream.Dispose();
            return $@"Файл {FileName} успішно відправлений!";
        }

        public string GetFormatedFileSize()
        {
            if (FileSizeInBytes < 1024)
            {
                return $"{FileSizeInBytes} б";
            }

            if (FileSizeInBytes < 1_048_576)
            {
                return $"{(double)FileSizeInBytes / 1024:F} кб";
            }

            return $"{(double)FileSizeInBytes / 1_048_576:F} мб";

        }

        public object Clone()
        {
            return  new Document(_filePath);
        }
    }
}