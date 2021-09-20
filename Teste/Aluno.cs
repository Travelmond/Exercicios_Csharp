using Teste;
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
        public string nome;
        public double p1;
        public double p2;



        public static void Campo_1()
        {
            Console.WriteLine("\nDigite o nome do aluno: ");
        }

        public static void Campo_2()
        {
            Console.WriteLine("\nDigite a primeira nota: ");
        }

        public static  void Campo_3()
        {
            Console.WriteLine("\nDigite a segunda nota: ");
        }

        public static void Campo_Erro_1()
        {
            Console.WriteLine("Digite um nome válido para o aluno da próxima vez!");
        }

        public static void Campo_Erro_2()
        {
            Console.WriteLine("\nDigite um valor válido para a nota da próxima vez!");
        }

        public static void Campo_Aprovado()
        {
            Console.WriteLine("O aluno foi aprovado!");
        }

        public static void Campo_Reprovado()
        {
            Console.WriteLine("O aluno foi reprovado!");
        }

        public static void Campo_Resultado()
        {
            Console.WriteLine("\nA média de notas do aluno é: ");
        }
    }


}


