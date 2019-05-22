using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Telegram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int styleNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
            StyleChange();
        }

        public void StyleChange()
        {
            string style;
            styleNumber = 1 - styleNumber;  // меняется номер 0 на 1, 1 на 0.

            if (styleNumber == 0)
            {
                style = "light";
            }
            else
            {
                style = "dark";
            }
            // определяем путь к файлу ресурсов

            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StyleChange();
        }

    }
}
