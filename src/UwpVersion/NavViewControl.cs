using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpVersion
{
    public class NavViewControl : NavigationView
    {
        public NavViewControl()
        {
            //TemplateSettings.SetValue(NavigationViewTemplateSettings.TopPaddingProperty, 0d);
        }

        protected override void OnApplyTemplate()
        {
            //TemplateSettings.TopPadding = 0; ;
            base.OnApplyTemplate();
            var topnavPad = GetTemplateChild("TopNavTopPadding") as UIElement;
            if (topnavPad != null)
                topnavPad.Visibility = Visibility.Collapsed;
            var toggleTopnavPad = GetTemplateChild("TogglePaneTopPadding") as UIElement;
            if (toggleTopnavPad != null)
                toggleTopnavPad.Visibility = Visibility.Collapsed;
        }
    }
}
