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
    public partial class Madera : ContentPage
    {
        public Madera()
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
        public async void ListaMad_Clicked(object sender, EventArgs e)
        {

            Selector selector = new Selector();
            selector.SelectorUno = "ACABADOS";
            selector.SelectorDos = "PARA MADERAS";
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