using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebViewUWPIOT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        private void Go_Web_Click(object sender, RoutedEventArgs e)
        {
            DoWebNavigate();
        }

        private void Web_Address_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                DoWebNavigate();
            }
        }

        private async void DoWebNavigate()
        {
            try
            {
                if (Web_Address.Text.Length > 0)
                {
                    webView.Navigate(new Uri(Web_Address.Text));

                }
                else
                {
                    MessageDialog dlg = new MessageDialog("Você precisa entrar com o link.");
                    await dlg.ShowAsync();
                }
            }
            catch (Exception e)
            {
                MessageDialog dlg = new MessageDialog("Erro: " + e.Message);
                await dlg.ShowAsync();

            }
        }
    }
}
