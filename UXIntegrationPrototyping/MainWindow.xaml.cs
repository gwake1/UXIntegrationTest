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

namespace UXIntegrationPrototyping
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
        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            LeftButton.Content = "Touched";
            CoolBox.Text = "Left";
            ResetBox.IsEnabled = true;
            RightButton.IsEnabled = false;
        }
        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            RightButton.Content = "Touched";
            CoolBox.Text = "Right";
            ResetBox.IsEnabled = true;
            LeftButton.IsEnabled = false;
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            CoolBox.Text = "";
            LeftButton.IsEnabled = true;
            RightButton.IsEnabled = true;
        }
    }
}
