using Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Media
    {
        public double media;
        public bool passou;


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

            if (media >= 7)
            {
                passou = true;
            }
            else
            {
                passou = false;
            }
            return passou;
        }
    }
}
