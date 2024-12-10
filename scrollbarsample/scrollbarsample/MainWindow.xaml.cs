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
using System.Diagnostics;
namespace scrollbarsample
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
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Ensure the slider is not null and update the TextBlock with the current value
            //Debug.WriteLine("Slider Value Changed: " + e.NewValue);
            //sliderValueText.Text = ((int)mySlider.Value).ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Imagepopup popup = new Imagepopup();
            popup.ShowDialog();
        }
    }
}
