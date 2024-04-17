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

namespace TennisScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ScoreManager scoreManager = new ScoreManager();
        
        public MainWindow()
        {
            InitializeComponent();

            var uri = new Uri("https://www.freewebheaders.com/wp-content/gallery/tennis/creative-tennis-header.jpg");
            ImgBanner.Source = new BitmapImage(uri);
            Scorebox.Text = "0 - 0";
        }

        private void Player1Btn_OnClick(object sender, RoutedEventArgs e)
        {
            scoreManager.Player1Scored();
            if (scoreManager.GetScore() == "Game Player1")
            {
                
            }
           Scorebox.Text = scoreManager.GetScore();
        }

        private void Player2Btn_OnClick(object sender, RoutedEventArgs e)
        {
            scoreManager.Player2Scored();
            Scorebox.Text= scoreManager.GetScore();
        }
    }
}