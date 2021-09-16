using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste
{
    /*Classe do aluno e seus atributos*/
    class Aluno
    {
        string nome;
        double p1;
        double p2;

        /*Função da classe aluno*/
        public double Calcula_Media()
        {
            double media = (p1 + p2) / 2;
            return media;
        }

        /*Função da classe aluno*/
        public bool Verifica_Passou()
        {
            bool passou;
            double media = Calcula_Media();
            if(media>7){
                passou = true;
            }
            else
            {
                passou = false;
            }

            return passou;
        }
        /*Função Principal*/

        public static void Main(string[] args)
        {
            var n = new Aluno();
            Console.WriteLine("\nDigite a primeira nota do aluno: ");
            n.p1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a primeira nota do aluno: ");
            n.p2 = Double.Parse(Console.ReadLine());

            /*Quero utilizar os valores de retorno de "passou e "media" para mostrar na tela */

        }
    } 
}
