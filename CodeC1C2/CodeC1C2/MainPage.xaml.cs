using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CodeC1C2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addViews(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap1_AddingViews()));
        }

        private void arrayMarkup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_ArrayMarkup()));
        }

        private void referenceMarkup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_ReferenceMarkup()));
        }

        private void xamlConstructors(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_XAMLConstructors()));
        }

        private void settingProperty(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_SettingProperty()));
        }
    }
}
