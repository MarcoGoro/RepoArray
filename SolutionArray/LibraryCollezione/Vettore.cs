using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCollezione
{
    public class Vettore
    {
        public static int[] Ordinamento(int[] numeri)
        {
            for(int i = 0; i < numeri.Length-1; i++)
            {
                for(int j = 0; j < numeri.Length; j++)
                {
                    if (numeri[i] > numeri[j])
                    {
                        int tmp = numeri[i];
                        numeri[i] = numeri[j];
                        numeri[j] = tmp;
                    }                   
                }
            }
            return numeri;
        }
    }
}
