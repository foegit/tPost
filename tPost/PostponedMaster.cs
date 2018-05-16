using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types;

namespace tPost
{
    public class PostponedMaster
    {
        public List<PostponedTelegramMessage> MessageList;

        private object locker = new object();

        private BackgroundWorker worker;        

        public PostponedMaster()
        {   
           
            MessageList = new List<PostponedTelegramMessage>();
            worker = new BackgroundWorker();

            worker.DoWork += StartMonitor;
            worker.WorkerSupportsCancellation = true;


        }



        private async void StartMonitor(object sender, EventArgs args)
        {
            
            while (true)
            {
               
                Thread.Sleep(1000);
                
               for  (int i = 0; i < MessageList.Count; i++)
                {

                    
                    if (( DateTime.Now.Minute >= MessageList[i].Time.Minute && DateTime.Now.Hour == MessageList[i].Time.Hour)  && MessageList[i].Validation && !MessageList[i].IsSend)
                    {
                        try
                        {
                            //MessageBox.Show($@"відправка: {DateTime.Now:T}, зараз: {t.Time:T}");
                            await MessageList[i].Message.Send();
                            lock (locker)
                            {
                                MessageList[i].IsSend = true;
                            }

                        }
                        catch (Exception e)
                        {

                            MessageList[i].Validation = false;

                        }

                    }
                }
            }
        }




        public void AddMessage(PostponedTelegramMessage message)
        {
            lock (locker)
            {
                MessageList.Add((PostponedTelegramMessage)message.Clone());
            }
            
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();

            }


        }


    }
}