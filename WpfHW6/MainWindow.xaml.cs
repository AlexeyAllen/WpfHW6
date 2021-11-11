using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfHW6
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt| Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllLines(saveFileDialog.SafeFileName, allText);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        WheatherControl wheatherControl = new WheatherControl();
        public String[] allText = new String[4];

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "Температура: " + wheatherControl.TemperatureRange();
            textBox2.Text = "Направление ветра: " + wheatherControl.WindDirection();
            textBox3.Text = "Скорость ветра: " + wheatherControl.WindSpeed();
            textBox4.Text = "Осадки: " + wheatherControl.WeatherPrecipit();
            CollectData();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "Температура: " + wheatherControl.TemperatureRange();
            textBox2.Text = "Направление ветра: " + wheatherControl.WindDirection();
            textBox3.Text = "Скорость ветра: " + wheatherControl.WindSpeed();
            textBox4.Text = "Осадки: " + wheatherControl.WeatherPrecipit();
            CollectData();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "Температура: " + wheatherControl.TemperatureRange();
            textBox2.Text = "Направление ветра: " + wheatherControl.WindDirection();
            textBox3.Text = "Скорость ветра: " + wheatherControl.WindSpeed();
            textBox4.Text = "Осадки: " + wheatherControl.WeatherPrecipit();
            CollectData();
        }

        public void CollectData()
        {
            allText.SetValue(textBox1.Text, 0);
            allText.SetValue(textBox2.Text, 1);
            allText.SetValue(textBox3.Text, 2);
            allText.SetValue(textBox4.Text, 3);
        }
    }
    
}
