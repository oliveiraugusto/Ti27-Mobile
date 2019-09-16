using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/* Faça um programa que leia um número entre 0 e 10, e escreva este número por extenso.
 */

namespace Exercicio01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercicio03 : ContentPage
	{
		public Exercicio03 ()
		{
			InitializeComponent ();
		}

        private void ButtonMostrar_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(entryNumeroExtenso.Text);
            string extenso = "";

            switch(numero)
            {
                case 0:
                    extenso = "ZERO";
                    break;

                case 1:
                    extenso = "UM";
                    break;

                case 2:
                    extenso = "DOIS";
                    break;

                case 3:
                    extenso = "TRÊS";
                    break;

                case 4:
                    extenso = "QUATRO";
                    break;

                case 5:
                    extenso = "CINCO";
                    break;

                case 6:
                    extenso = "SEIS";
                    break;

                case 7:
                    extenso = "SETE";
                    break;

                case 8:
                    extenso = "OITO";
                    break;

                case 9:
                    extenso = "NOVE";
                    break;

                case 10:
                    extenso = "DEZ";
                    break;
            }

            DisplayAlert("Por Extenso", extenso, "OK");
        }
    }
}