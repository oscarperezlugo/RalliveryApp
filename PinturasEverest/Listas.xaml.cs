using PinturasEverest.Conexiones;
using PinturasEverest.Datos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PinturasEverest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listas : ContentPage
    {
        public Listas(Selector selector)
        {
            InitializeComponent();
            Repositorio repo = new Repositorio();
            Colores[] listacolores = repo.getColores();
            if (selector.SelectorDos == null)
            {
                var myColors = listacolores.Where(u => u.Categoria == selector.SelectorUno).ToList();
                ListaColores.ItemsSource = myColors;
            }
            else
            {
                var myColors = listacolores.Where(u => u.Categoria == selector.SelectorUno && u.Linea == selector.SelectorDos).ToList();
                ListaColores.ItemsSource = myColors;
            }            
                                 
        }                        

        private  void ListaColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.CurrentSelection);
        }
        async void UpdateSelectionData(IEnumerable<object> currentSelectedContact)
        {
            var selectedContact = currentSelectedContact.FirstOrDefault() as Colores;
            Colores colores = new Colores();
            colores.Categoria = selectedContact.Categoria;
            colores.Codigo = selectedContact.Codigo;
            colores.Color = selectedContact.Color;
            colores.Linea = selectedContact.Linea;
            colores.Nombre = selectedContact.Nombre;
            Detalle myHomePage = new Detalle(colores);
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