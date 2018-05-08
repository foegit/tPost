using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types;
using Message = Telegram.Bot.Types.Message;

namespace tPost.IMessageContent
{
    public class Document : IMessageContent
    {
        public int TextMaxLength { get; }

        private FileToSend _documentToSend;
        public long FileSizeInBytes { get; private set; }
        public string FileName;

        public Document()
        {
            TextMaxLength = 201;


        }

        public Document(string filePath) : this()
        {
            SetFileToSend(filePath);
        }

        public void SetFileToSend(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open);

            if (fileStream.CanRead)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                FileName = fileInfo.Name;

                FileSizeInBytes = fileInfo.Length;

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
                throw new FileNotFoundException($"Не знайдено файл!\n{filePath}");
            }

        }


        public async Task<Message> Send(TelegramMessage msg)
        {

            var res = await msg.Bot.SendDocumentAsync(msg.CanalName, _documentToSend, msg.Text, msg.DisableNotification);
            MessageBox.Show(@"Файл успішно відправлений!");
            return res;
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
    }
}