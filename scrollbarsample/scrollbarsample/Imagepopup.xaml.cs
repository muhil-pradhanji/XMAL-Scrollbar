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
using System.Windows.Shapes;

namespace scrollbarsample
{
    /// <summary>
    /// Interaction logic for Imagepopup.xaml
    /// </summary>
    public partial class Imagepopup : Window
    {
        public Imagepopup()
        {
            InitializeComponent();
         

        }
        //private void BrightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (DisplayedImage != null) // Check if the image is initialized
        //    {
        //        DisplayedImage.Opacity = BrightnessSlider.Value / 100.0;
        //        sliderValueText.Text = "Brightness: " + (int)BrightnessSlider.Value;
        //    }
        //}

        private void Scroll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (DisplayedImage != null) // Check if the image is initialized
            {
                DisplayedImage.Opacity = Scroll.Value / 100.0;
                sliderValueText.Text = "Brightness: " + (int)Scroll.Value;
                
            }
        }
    }
}