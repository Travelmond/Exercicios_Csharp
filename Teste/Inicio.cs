using Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiNET.Plugins;

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

            /*Estrutura de Loop+Condicional que valida o que foi escrito no campo Aluno*/
            while (string.IsNullOrWhiteSpace(n.nome))
            {
                Aluno.Campo_1();
                n.nome = Console.ReadLine();
               
                break;
            }

            if (string.IsNullOrEmpty(n.nome))
            {
                Console.Clear();
                Aluno.Campo_Erro_1();
                Console.ReadKey();
                goto inicio;
            }
            /*---------------------------------------------------------------------------*/

            /*Estrutura de Try+Catch que valida o que foi escrito no campo Nota_Aluno_1*/

            try
            {
                Aluno.Campo_2();
                n.p1 = Double.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.Clear();
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }
            catch (Exception e)
            {
                Console.Clear();
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }

            /*while (Double.Parse(Console .ReadLine()))
            {
                Console.Clear();
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }
            */
            /*---------------------------------------------------------------------------------*/

            /*Estrutura de Try+Catch que valida o que foi escrito no campo Nota_Aluno_2*/
            try
            {
                Aluno.Campo_3();
                n.p2 = Double.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.Clear();
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }
            catch (Exception e)
            {
                Console.Clear();
                Aluno.Campo_Erro_2();
                Console.ReadKey();
                goto inicio;
            }
            /*----------------------------------------------------------------------------------*/



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
