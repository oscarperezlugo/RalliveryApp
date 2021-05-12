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
    public partial class Industrial : ContentPage
    {
        public Industrial()
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
        public async void ListaFonHerr_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "GAMMAS";
            selector.SelectorDos = "FONDOS DE HERRERIA";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaFonInd_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "PINTURAS PARA CANCHAS";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaFonInddOS_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "FONDOS INDUSTRIALES";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaEpoxys_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ACABADOS";
            selector.SelectorDos = "EPOXYS (2 COMPONENTES 4:1)";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaEpoxysFond_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "FONDOS EPOXYS";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void EsmaltMart_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ESMALTES";
            selector.SelectorDos = "MARTILLADOS S/R";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void EsmaltMet_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ESMALTES";
            selector.SelectorDos = "METALIZADOS Y ALUMINIOS S/R";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void EsmaltInt_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ESMALTES";
            selector.SelectorDos = "INDUSTRIALES S/R";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        //public async void ListaPinCanc_Clicked(object sender, EventArgs e)
        //{
        //    Selector selector = new Selector();
        //    selector.SelectorUno = "INDUSTRIAL";
        //    selector.SelectorDos = "";
        //    Listas myHomePage = new Listas(selector);
        //    NavigationPage.SetHasNavigationBar(myHomePage, true);
        //    await Navigation.PushModalAsync(myHomePage);
        //}
        public async void ListaElastTech_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "ELASTOMERICO TECHOS";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaPintraf_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "TRAFICO";
            Listas myHomePage = new Listas(selector);
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void ListaCaucho_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "INDUSTRIAL";
            selector.SelectorDos = "CAUCHO CLORADO";
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