using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NowKPop
{
    /// <summary>
    /// Windows app page that navigates to nowkpop.com and does some magic. :)
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			NowKPopWeb.Navigate(new Uri("https://nowkpop.com"));
	        appBar.IsOpen = true;
	        appBar.IsSticky = false;
        }

	    private void HomeButton_OnClick(object sender, RoutedEventArgs e)
	    {
			NowKPopWeb.Navigate(new Uri("https://nowkpop.com"));
			appBar.IsOpen = false;
	    }

	    private void LoginButton_OnClick(object sender, RoutedEventArgs e)
	    {
			NowKPopWeb.Navigate(new Uri("http://nowkpop.com/wp-login.php?redirect_to=http%3A%2F%2Fnowkpop.com%2Fwp-admin%2F&reauth=1"));
		    appBar.IsOpen = false;
	    }

        private void dashboardButton_OnClick(object sender, RoutedEventArgs e)
        {
            NowKPopWeb.Navigate(new Uri("http://nowkpop.com/wp-admin"));
            appBar.IsOpen = false;
        }

        private void rssButton_OnClick (object sender, RoutedEventArgs e)
        {
            NowKPopWeb.Navigate(new Uri("http://feeds.feedburner.com/NowKPop"));
            appBar.IsOpen = false;
        }
    }
}
