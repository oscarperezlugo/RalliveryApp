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
    public partial class Autos : ContentPage
    {
        public Autos()
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
        public async void LacAut_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "LACAS AUTOMOTRICES";
            selector.SelectorDos = "AUTOLAC";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void PerlAc_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "PERLAS ACRILICAS";
            selector.SelectorDos = "AUTOLAC";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Aut_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "FONDOS AUTOMOTRICES";
            selector.SelectorDos = "AUTOLAC";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Poli_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "POLIURETANOS";
            selector.SelectorDos = "AUTOLAC";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void PoliAut_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ACABADOS";
            selector.SelectorDos = "POLIURETANOS";
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