using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void WinUI_Click(object sender, RoutedEventArgs e)
        {
            var welcomeDialog = new ContentDialog()
            {
                Title = "Hello from Hello Kita,Nice Job",
                Content = "Welcome to my first Windows App SDK app, 20240125",
                CloseButtonText = "OK, Goood!!!",
                XamlRoot = WinUI_Learn.XamlRoot

            };
            await welcomeDialog.ShowAsync();
            ///myButton.Content = "Clicked";
        }
    }
}