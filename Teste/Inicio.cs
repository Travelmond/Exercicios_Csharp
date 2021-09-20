using Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
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


            switch (n.nome)
            {
                case "":
                    Aluno.Campo_Erro_1();
                    Console.ReadKey();
                    goto inicio;
                case null:
                    Aluno.Campo_Erro_1();
                    Console.ReadKey();
                    goto inicio;
                case String.Parse(double):
                    Console.ReadKey();
                    goto inicio;
            }


            Aluno.Campo_2();
            n.p1 = Double.Parse(Console.ReadLine());
            Type t2 = n.p1.GetType();


            Aluno.Campo_3();
            n.p2 = Double.Parse(Console.ReadLine());
            /*(double.IsNaN(n.p2) || double.IsNegative(n.p2))*/

            
            switch (n.p1)
            {
                case double.NaN:
                    Aluno.Campo_Erro_2();
                    Console.ReadKey();
                    goto inicio;
            }
            switch (n.p2)
            {
                case double.NaN:
                    Aluno.Campo_Erro_2();
                    Console.ReadKey();
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
