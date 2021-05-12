using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PinturasEverest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        public async void Caucho_Clicked(object sender, EventArgs e)
        {
            Caucho myHomePage = new Caucho();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Esmaltes_Clicked(object sender, EventArgs e)
        {
            Esmalte myHomePage = new Esmalte();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Industrial_Clicked(object sender, EventArgs e)
        {
            Industrial myHomePage = new Industrial();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Madera_Clicked(object sender, EventArgs e)
        {
            Madera myHomePage = new Madera();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Autos_Clicked(object sender, EventArgs e)
        {
            Autos myHomePage = new Autos();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void YouTube_Clicked(object sender, EventArgs e)
        {
            Youtube myHomePage = new Youtube();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Facebook_Clicked(object sender, EventArgs e)
        {
            Facebook myHomePage = new Facebook();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Instagram_Clicked(object sender, EventArgs e)
        {
            Instagram myHomePage = new Instagram();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        
    }
}
