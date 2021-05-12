using PinturasEverest.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PinturasEverest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Esmalte : ContentPage
    {
        public Esmalte()
        {
            InitializeComponent();
        }
        public async void Calculadora_Clicked(object sender, EventArgs e)
        {
            Selector selector = new Selector();
            selector.SelectorUno = null;
            selector.SelectorDos = null;
            Calculadora myHomePage = new Calculadora(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaGam_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "GAMMAS";
            selector.SelectorDos = "ESMALTE";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaKon_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "KONTRASTES";
            selector.SelectorDos = "ESMALTE";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Home_Clicked(object sender, EventArgs e)
        {

            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Back_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopModalAsync();
        }
    }
}