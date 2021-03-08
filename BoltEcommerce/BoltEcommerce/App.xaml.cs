using FormsControls.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoltEcommerce
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimationNavigationPage(new Views.WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
