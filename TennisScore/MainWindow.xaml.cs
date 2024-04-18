using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TennisScore.Manager;
using TennisScore.ViewModels;


namespace TennisScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //använder MVVM för att binda data till UI
        //manager hanteras även i viewmodellen
        public MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();
            DataContext = ViewModel;
            var uri = new Uri("https://www.freewebheaders.com/wp-content/gallery/tennis/creative-tennis-header.jpg");
            ImgBanner.Source = new BitmapImage(uri);
        }

        private void Player1Btn_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Player1Scored();
        }

        private void Player2Btn_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Player2Scored();
        }
    }
}