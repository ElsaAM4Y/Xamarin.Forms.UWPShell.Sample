using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpVersion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().
            //titleBar.BackgroundColor = titleBar.ButtonBackgroundColor = Colors.Orange;
            var titleBar = Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar;
            titleBar.ExtendViewIntoTitleBar = false;
        }

        private void NvSample_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            
        }

        private void NvSample_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
        {
            if(args.DisplayMode == NavigationViewDisplayMode.Minimal)
                Header.Padding = new Thickness(100, 0, 0, 0);
            else
                Header.Padding = new Thickness(0, 0, 0, 0);

            if (args.DisplayMode == NavigationViewDisplayMode.Expanded)
                PaneHeader.Visibility = Visibility.Visible;
            else
                PaneHeader.Visibility = Visibility.Collapsed;
        }
    }
}
