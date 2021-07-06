 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMTest001.View;

namespace MVVMTest001
{
    public partial class App : Application
    {
        public App() {
            InitializeComponent();

            MainPage = new JamesPage();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
