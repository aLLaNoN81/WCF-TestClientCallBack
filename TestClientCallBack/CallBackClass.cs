using System.Windows;
using TestClientCallBack.WCFServiceCallback;

namespace TestClientCallBack
{
    public class RequestCallBack : IServiceCallback
    {
        public int Id;

        public void SendResultBroadcast(string text)
        {
            MessageBox.Show(text);
        }

        public void SendResult(int id, string text)
        {
            if (Id == id)
            {
                MessageBox.Show("ID " + Id.ToString() + " - " + text);
            }
        }
    }
}