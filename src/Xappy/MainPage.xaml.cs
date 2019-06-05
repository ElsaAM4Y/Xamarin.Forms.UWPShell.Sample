﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xappy.Domain.Global;
using Xappy.Services;

namespace Xappy
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            SettingsService.UseFlyout(this);
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            SettingsService.UseTabs(this);
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            DependencyService
                .Get<AppTheme>()
                .SetTheme(XappyTheme.Default);
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            DependencyService
                .Get<AppTheme>()
                .SetTheme(XappyTheme.Clancey);
        }
    }
}
