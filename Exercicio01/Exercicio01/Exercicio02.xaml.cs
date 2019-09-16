using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*Faça um aplicativo que, dado os valores de quilômetros rodados 
 * e do combustível abastecido, faça o cálculo da rodagem do mesmo
 */


namespace Exercicio01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercicio02 : ContentPage
	{
		public Exercicio02 ()
		{
			InitializeComponent ();
		}

        private void EntryCalcular_Clicked(object sender, EventArgs e)
        {
            double kilometros = Convert.ToDouble(entryKilometros.Text);
            double combustivel = Convert.ToDouble(entryCombustivel.Text);

            double resultado = kilometros / combustivel;

            DisplayAlert("Sucesso!", "O carro rodou " + resultado + "Km/L", "beleza!");
        }
    }
}