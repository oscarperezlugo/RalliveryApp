using PinturasEverest.Conexiones;
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
    public partial class Calculadora : ContentPage
    {
        string selectoruno;
        string selectordos;
        string rendimiento;
        public Calculadora(Selector selector)
        {
            InitializeComponent();

            if (selector.SelectorUno == null)
            {
                Repositorio repo = new Repositorio();
                Colores[] listacategoria = repo.getColores();
                var myUser = listacategoria.Select(u => u.Categoria).Distinct().ToList();
                Tipo.ItemsSource = myUser;
                Producto.IsEnabled = false;
                Metros.IsEnabled = false;
            }
            else
            {
                Repositorio repo = new Repositorio();
                Colores[] listacategoria = repo.getColores();
                var myUserTres = listacategoria.Where(u => u.Categoria == selector.SelectorUno && u.Linea == selector.SelectorDos).Select(x => x.Rendimiento).FirstOrDefault();
                rendimiento = myUserTres.ToString();                
                Tipo.Title = selector.SelectorUno;
                Producto.Title = selector.SelectorDos;
                Producto.IsEnabled = false;
                Tipo.IsEnabled = false;
            }

            
            
            
        }

        private void Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectoruno = Tipo.SelectedItem.ToString();
            Repositorio repo = new Repositorio();
            Colores[] listacategoria = repo.getColores();
            var myUserDos = listacategoria.Where(u => u.Categoria == selectoruno).Select(x => x.Linea).Distinct().ToList();
            Producto.ItemsSource = myUserDos;
            Producto.IsEnabled = true;
        }

        private void Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectordos = Producto.SelectedItem.ToString();
            Repositorio repo = new Repositorio();
            Colores[] listacategoria = repo.getColores();
            var myUserTres = listacategoria.Where(u => u.Categoria == selectoruno && u.Linea == selectordos).Select(x => x.Rendimiento).FirstOrDefault();
            rendimiento = myUserTres.ToString();
            Metros.IsEnabled = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double metros = Double.Parse(Metros.Text);
            double rendimientox = Double.Parse(rendimiento);
            double resultadox = metros * rendimientox;
            Resultado.Text = resultadox.ToString();
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