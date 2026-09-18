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
        private const string WeatherTokyo = "https://tenki.jp/leisure/horse/3/16/32005/1hour.html";
        private const string WeatherNakayama = "https://tenki.jp/leisure/horse/3/15/32004/1hour.html";
        private const string WeatherKyoto = "https://tenki.jp/leisure/horse/6/29/32007/1hour.html";
        private const string WeatherHanshin = "https://tenki.jp/leisure/horse/6/31/32008/1hour.html";

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

        private void WeatherTokyoButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = WeatherTokyo;
        }

        private void WeatherNakayamaButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = WeatherNakayama;
        }

        private void WeatherKyotoButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = WeatherKyoto;
        }

        private void WeatherHanshinButton_Click(object sender, RoutedEventArgs e)
        {
            RightBrowser.Address = WeatherHanshin;
        }
    }
}