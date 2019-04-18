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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShellSample.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SampleSelector : Page
    {
        public SampleSelector()
        {
            var titleBar = Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar;
            titleBar.ExtendViewIntoTitleBar = false;
            this.InitializeComponent();
        }

        private void DefaultShell_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new ShellSample.App());
        }

        private void GastroPods_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new Gastropod.App());
        }

        private void Xappy_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new Xappy.App());
        }
    }
}
