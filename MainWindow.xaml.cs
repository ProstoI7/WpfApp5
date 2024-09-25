using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RedBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Red;
        }
        private void GreenBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Green;
        }
        private void BlueBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Blue;
        }
        private void AboutDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("zzzz", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void MouseEnRed(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на красный";
        }
        private void MouseEnGreen(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на зелёный";
        }
        private void MouseEnBlue(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на синий";
        }
        private void MouseEnRazrab(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Просмотреть информацию о ракработчике";
        }
        private void MouseEnExit(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Закрыть программу";
        }
        private void MouseEnFail(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Просмотреть возможные действия с файлом";
        }
        private void MouseEnFon(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон";
        }
        private void MouseEnInfo(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Просмотреть информацию о файле";
        }
        private void MouseLeave(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = " ";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}