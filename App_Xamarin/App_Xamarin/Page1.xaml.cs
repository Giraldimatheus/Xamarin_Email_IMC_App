using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void CalcularIMC_Clicked(object sender, EventArgs e)
        {
            // Obter os valores dos Entry
            string nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            // Calcular o IMC
            double imc = peso / (altura * altura);

            // Exibir o resultado
            lblIMC.Text = $"IMC de {nome}: {imc:F2}";
        }
    }

}