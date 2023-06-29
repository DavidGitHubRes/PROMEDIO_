using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PROMEDIO_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(n1.Text);
                double nota2 = Convert.ToDouble(n2.Text);
                double nota3 = Convert.ToDouble(n3.Text);
                double nota4 = Convert.ToDouble(n4.Text);
                double nota5 = Convert.ToDouble(n5.Text);

                double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                prom.Text = "PROMEDIO: " + promedio;
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", "Revise los campos: Error--> " + ex.Message, "Aceptar");
            }
        }
    }
}
