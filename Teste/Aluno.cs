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

        /*Se o usuario não inserir os dados do campo aluno, voltar para o inicio*/
        inicio:

            Console.Clear();

            var n = new Aluno();
            Console.WriteLine("\nDigite o nome do aluno: ");
            n.nome = Console.ReadLine();
            Type t = n.nome.GetType();
            if (string.IsNullOrWhiteSpace(n.nome) || n.nome.Equals(typeof(double)))
            {
                Console.WriteLine("Digite um nome válido para o aluno da próxima vez!");
                Console.ReadKey();
                goto inicio;
            }

            Console.WriteLine("\nDigite a primeira nota do aluno: ");
            n.p1 = Double.Parse(Console.ReadLine());
            Console.WriteLine(n.p1.GetType());
            Type t2 = n.p1.GetType();
            if (double.IsNaN(n.p1) || double.IsNegative(n.p1) || n.nome.Equals(typeof(string)))
            {
                Console.WriteLine("\nDigite um valor válido para a nota da próxima vez!");
                Console.ReadKey();
                goto inicio;
            }

            Console.WriteLine("\nDigite a segunda nota do aluno: ");
            n.p2 = Double.Parse(Console.ReadLine());
            if (double.IsNaN(n.p2) || double.IsNegative(n.p2))
            {
                Console.WriteLine("\nDigite um valor válido para a nota da próxima vez!");
                goto inicio;
            }

            double resultado = n.Calcula_Media(n.p1, n.p2);
            bool resultado_2 = n.Verifica_Passou();
            /*-------------------------------------------------------------------*/
           

            
            Console.WriteLine("\nA média de notas do aluno é: " +resultado);
            switch (resultado_2)
            {
                case true:
                    Console.WriteLine("O aluno foi aprovado");
                    break;

                case false:
                    Console.WriteLine("O aluno foi reprovado");
                    break;
            }

            Console.ReadKey();


        }

    } 
}
