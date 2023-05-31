using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_R3
{
    internal class Algoritmo
    {
        /*
         * > Primeira Tarefa
         *   Criar uma função para Calcular a regra de tres simples
         *      1. [X] Receber todos valores para calculo
         *      2. [X] Verificar se a opção escolhida é a regra de tres simples
         *      3. [X] Realizar calculo e retornar o resultado
         */

        public float Simples(bool[] regra, string v1, string v2, string v3, string v4)
        {
            float value3 = 0;
            float value4 = 0;
            float mult1;
            float mult2;
            float div;
            float result = 0;

            // regra de tres simples direta
            if (v4 == "x" && regra[0]) 
            {
                value4 = 1;
                mult1 = float.Parse(v1) * value4;
                mult2 = float.Parse(v2) * float.Parse(v3);
                div = mult2 / mult1;
                result = div;
            }
            else
            {
                if(v3 == "x" && regra[0])
                {
                    value3 = 1;
                    mult1 = float.Parse(v2) * value3;
                    mult2 = float.Parse(v1) * float.Parse(v4);
                    div = mult2 / mult1;
                    result = div;
                }
            }

            // regra de tres simples inversa
            if (v4 == "x" && regra[1]) 
            {
                value4 = 1;
                mult1 = float.Parse(v3) * value4;
                mult2 = float.Parse(v1) * float.Parse(v2);
                div = mult2 / mult1;
                result = div;
            }
            else
            {
                if(v3 == "x" && regra[1]) 
                {
                    value3 = 1;
                    mult1 = float.Parse(v4) * value3;
                    mult2 = float.Parse(v1) * float.Parse(v2);
                    div = mult2 / mult1;
                    result = div; 
                }
            }
            return result;
        }

        public float Composta(bool regra, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            float value4 = 0;
            float mult1;
            float mult2;
            float div;
            float result = 0;

            return result;
        }
    }
}
