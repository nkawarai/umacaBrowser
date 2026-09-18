using MahApps.Metro.Controls;
using System.Windows;

namespace SmartRCEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private const string UmakaUrl = "https://www.ipat.jra.go.jp/sp/umaca/";
        private const string JraUrl = "https://www.jra.go.jp/";
        private const string JRAYoutubeUrl = "https://www.youtube.com/@jraofficial/featured";
        private const string KeibaSalonUrl = "https://www.keiba-salon.com/";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UmakaButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = UmakaUrl;
        }

        private void JRAButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = JraUrl;
        }

        private void JRAYoutubeButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = JRAYoutubeUrl;
        }

        private void KeibaSalonButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = KeibaSalonUrl;
        }
    }
}