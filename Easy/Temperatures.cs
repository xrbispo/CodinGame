using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string TEMPS = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526
        
        if (N == 0){
            // Retorna 0 se nenhuma temperatura for informada
            Console.WriteLine("0");
        }
        else {
            
            // Converte TEMPS em um array de int
            int[] newTemps = Array.ConvertAll(TEMPS.Split(' '),i => Convert.ToInt32(i));

            // Primeira temperatura para comparação
            int closerTemp = newTemps[0];
            
            for(int i = 1; i < newTemps.Length; i++){
                // Multiplicando numeros negativos resulta em numero positivo
                // Isso simplifica a comparação para apenas o lado positivo
                if(newTemps[i]*newTemps[i] <= closerTemp*closerTemp){
                    closerTemp = newTemps[i];     
                }
            }
            // Retorna resultado
            Console.WriteLine(closerTemp);    
        }
        // Write an action using Console.WriteLine()
    }
}
