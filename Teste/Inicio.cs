using Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    /// <summary>
    /// /Teste
    /// </summary>
    class Inicio
    {

        /*Função Principal*/
        public static void Main(string[] args)
        {

        /*Se o usuario não inserir os dados do campo aluno, voltar para o inicio*/
        inicio:

            Console.Clear();

            var n = new Aluno();
            var m = new Media();
            Aluno.Campo_1();
            n.nome = Console.ReadLine();
            Type t = n.nome.GetType();
            if (string.IsNullOrWhiteSpace(n.nome) || n.nome.Equals(typeof(double)))
            {
                Aluno.Campo_Erro_1();
                Console.ReadKey();
                goto inicio;
            }

            Aluno.Campo_2();
            n.p1 = Double.Parse(Console.ReadLine());
            Type t2 = n.p1.GetType();
            if (double.IsNaN(n.p1) || double.IsNegative(n.p1) || n.nome.Equals(typeof(string)))
            {
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }

            Aluno.Campo_3();
            n.p2 = Double.Parse(Console.ReadLine());
            if (double.IsNaN(n.p2) || double.IsNegative(n.p2))
            {
                Aluno.Campo_Erro_2();
                goto inicio;
            }

            /*Criado objetos chamando os atributos das classes "Aluno" e "Media" */
            double resultado = m.Calcula_Media(n.p1, n.p2);
            bool resultado_2 = m.Verifica_Passou();
            /*-------------------------------------------------------------------*/

            Aluno.Campo_Resultado();
            Console.WriteLine(resultado);

            switch (resultado_2)
            {
                case true:
                    Aluno.Campo_Aprovado();
                    break;

                case false:
                    Aluno.Campo_Reprovado();
                    break;
            }

            Console.ReadKey();


        }
    }
}
