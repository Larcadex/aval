using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace aval;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }
     
    private void Back_button(object sender, RoutedEventArgs e)
    {
        try
        {
            var win = new MainWindow();
        
            win.Show();
            
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
        finally
        {
            Hide();
        }
        
        
    }
}