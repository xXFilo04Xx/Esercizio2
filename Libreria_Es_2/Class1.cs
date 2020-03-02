using System;

namespace Libreria_Es_2
{
    public class Utilità
    {
        public static bool VerificaIntero(double n)
        {
            int n1 = (int)n;
            if (n1 == n)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public static int Arrotonda(double n)
        {
            int n1 =(int)(n + 0.5);
            return n1;
        }
        public static bool PariDispari(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
