using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/* Faça um aplicativo que receba o nome do aluno, 
 * duas notas e, caso o aluno tenha uma nota maior 
 * que 5 escreva na tela APROVADO, caso contrário escreva REPROVADO
 */
namespace Exercicio01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(entryNome.Text) ||
                string.IsNullOrEmpty(entryNota01.Text) ||
                string.IsNullOrEmpty(entryNota02.Text))
            {
                //deixe os campos em branco
            }
            else
            {
                Alunos a = new Alunos();
                double resultadoMedia = a.Media(Convert.ToDouble(entryNota01.Text),
                                                Convert.ToDouble(entryNota02.Text));
                if(resultadoMedia > 5)
                {
                    labelMedia.Text = "APROVADO";
                }
                else
                {
                    labelMedia.Text = "REPROVADO";
                }
            }
        }
    }
}
