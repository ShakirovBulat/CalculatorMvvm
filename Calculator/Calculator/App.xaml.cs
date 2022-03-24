using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    public partial class App : Application
    {
        CalculatorMvvm add;
        public App()
        {
            InitializeComponent();
            add = new CalculatorMvvm();
            add.RestoreState(Current.Properties);

            MainPage = new MainPage(add);
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
