using System;
using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace aval
{
    public partial class MainWindow : Window
    {
        private int cur_image = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_click(object sender, RoutedEventArgs args)
        {
            cur_image = cur_image + 1;
            if (cur_image == 4) cur_image = 0;

            switch (cur_image)
            {
                case 0:
                    Image0.IsVisible = true;
                    Image1.IsVisible = false;
                    Image2.IsVisible = false;
                    Image3.IsVisible = false;
                    break;
                case 1:
                    Image0.IsVisible = false;
                    Image1.IsVisible = true;
                    Image2.IsVisible = false;
                    Image3.IsVisible = false;
                    break;
                case 2:
                    Image0.IsVisible = false;
                    Image1.IsVisible = false;
                    Image2.IsVisible = true;
                    Image3.IsVisible = false;
                    break;
                case 3:
                    Image0.IsVisible = false;
                    Image1.IsVisible = false;
                    Image2.IsVisible = false;
                    Image3.IsVisible = true;
                    break;
            }
        }

        private void Close_button(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Reg_button(object sender, RoutedEventArgs e)
        {
           
                var win = new Window1();

                win.Show();
         
                Hide();
            
        }
    }
}

