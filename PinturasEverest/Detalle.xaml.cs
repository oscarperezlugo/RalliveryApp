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
    public partial class Detalle : ContentPage
    {
        string CATEGORIA;
        string LINEA;
        public Detalle(Colores colores)
        {
            InitializeComponent();

            colorete.BackgroundColor = Color.FromHex(colores.Color);
            tipete.Text = colores.Linea;
            categoriete.Text = colores.Categoria;
            nombrete.Text = colores.Nombre;
            codiguete.Text = colores.Codigo;
            CATEGORIA = colores.Categoria;
            LINEA = colores.Linea;
        }
        public async void Calculadora_Clicked(object sender, EventArgs e)
        {
            Selector selector = new Selector();
            selector.SelectorUno = CATEGORIA;
            selector.SelectorDos = LINEA;
            Calculadora myHomePage = new Calculadora(selector);
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