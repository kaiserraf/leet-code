using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Solution
{
    public int RomanToInt(string s)
    {
        var dic = new Dictionary<char, int> // criação de hashmap
        {
            // add valores
            {'I', 1}, {'V', 5}, {'X', 10}, 
            {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

        char[] simArr = s.ToCharArray(); // transforma string em um char[]
        int[] numArr = new int[simArr.Length]; // cria um int[] do mesmo tamanho de char[]

        for(int i = 0; i < simArr.Length; i++) // loop do tamanho do char[]
        {
            if(dic.TryGetValue(simArr[i], out int valor)){ numArr[i] = valor; } // ve valor dentro do hashmap e atribui o numero
        }

        int valorFinal = 0;
        int valorTotal = 0;
        int numUltimo = 0;

        for(int i = numArr.Length - 1; i >= 0; i--) // correr de tras pra frente
        {
            int numAtual = numArr[i];

            if(numAtual < numUltimo)
            {
                valorTotal -= numAtual;
            }
            else
            {
                valorTotal += numAtual;
            }

            numUltimo = numAtual;
        }

        return valorTotal;
    }
}