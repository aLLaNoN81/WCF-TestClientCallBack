using System.Windows;
using TestClientCallBack.WCFServiceCallback;

namespace TestClientCallBack
{
    public class RequestCallBack : IServiceCallback
    {
        public void SendResult()
        {
            MessageBox.Show("Received!");
        }
    }
}
