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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _request = new RequestCallBack();
            _instance = new InstanceContext(_request);
            _proxy = new ServiceClient(_instance);
            _proxy.GetData();
        }
    }
}