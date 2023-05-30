using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_R3
{
    internal class Algoritmo_R3
    {
        /*
         * > Primeira Tarefa
         *   Criar uma função para Calcular a regra de tres simples
         *      1. [X] Receber todos valores para calculo
         *      2. [X] Verificar se a opção escolhida é a regra de tres simples
         *      3. [X] Realizar calculo e retornar o resultado
         */

        public float Simples(bool regra, string v1, string v2, string v3, string v4)
        {
            float value4 = 0;
            float mult1;
            float mult2;
            float div;
            float result = 0;

            if (v4 == "x")
            {
                value4 = 1;
            }

            if (regra)
            {
                mult1 = float.Parse(v2)*float.Parse(v3);
                mult2 = float.Parse(v1) * value4;
                div = mult1 / mult2;
                result = div;
            }
            return result;
        }
    }
}
