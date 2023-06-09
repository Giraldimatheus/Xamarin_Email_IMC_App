using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void GerarEmailClicked(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string sobrenome = txtSobrenome.Text.Trim();

            string email = $"{sobrenome.ToLower()}{nome.ToLower()}@ufn.edu.br";

            lblEmail.Text = email;
        }
        
        private async void IrParaPage1Clicked(object sender, EventArgs e)
{
            await Navigation.PushAsync(new NavigationPage(new Page1()));
        }



    }
}
