using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste
{
    /*Classe do aluno e seus atributos*/
    public class Aluno
    {
        string nulo = string.Empty;
        string nome;
        double p1;
        double p2;

        double media;
        bool passou;

        /*Função da classe aluno*/
        public double Calcula_Media(double p1, double p2)
        {
            media = (p1 + p2) / 2;
            return media;
        }

        /*Função da classe aluno*/
        /*Quero utilizar o retorno de "media" na função Calcula_Media() e utlizar esta "media" na função Verifica_Passou()*/
        public bool Verifica_Passou()
        {
            
            if (media > 7)
            {
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
            Console.Clear();

        inicio:

            var n = new Aluno();
            Console.WriteLine("\nDigite o nome do aluno: ");
            n.nome = Console.ReadLine();
            Console.WriteLine("\nDigite a primeira nota do aluno: ");
            n.p1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a segunda nota do aluno: ");
            n.p2 = Double.Parse(Console.ReadLine());
            double resultado = n.Calcula_Media(n.p1, n.p2);

            /*Se o usuario não incerir os dados do campo aluno, voltar para o inicio*/
            Console.WriteLine("\nO nome do aluno é: "+n.nome);
            if (n.nome == n.nulo)
            {
                Console.WriteLine("Digite um nome válido para o aluno!");
                Console.Clear();
                goto inicio;

            }
            /*---------------------------------------------------------------------*/

            
            Console.WriteLine("\nA média de notas do aluno é: " +resultado);
            if(n.passou == true)
            {
                Console.WriteLine("O aluno foi aprovado");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado");
            }

            /*Quero utilizar os valores de retorno de "passou e "media" para mostrar na tela */


        }

    } 
}
