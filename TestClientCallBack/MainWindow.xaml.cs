using System.ServiceModel;
using System.Windows;
using TestClientCallBack.WCFServiceCallback;

namespace TestClientCallBack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RequestCallBack _request;
        private InstanceContext _instance;
        private ServiceClient _proxy;
        private int _id;

        public MainWindow()
        {
            InitializeComponent();

            _request = new RequestCallBack();
            _instance = new InstanceContext(_request);
            _proxy = new ServiceClient(_instance);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _proxy.GetData();
            //bool aa = _proxy.GetTest();
            //txb.Text = txb.Text + "-" + aa.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool aa = _proxy.GetTest();
            MessageBox.Show("Esito: " + aa.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _id = _proxy.Subscribe();
            _request.Id = _id;
            txb.Text = _id.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _proxy.Unsubscribe(_id);
        }
    }
}