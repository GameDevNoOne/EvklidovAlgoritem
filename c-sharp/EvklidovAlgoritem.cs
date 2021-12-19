using System;

namespace EuclidsAlgorithm{

    class EvklidovAlgoritem{
        
        //NSD = Največji skupni delitelj, x je večje število
        // y je manjše število
        public static int NSD(int x, int y)
        {   

            //Ponavlja dokler sta obe kondiciji izpolnjeni 
            while(x > y && y != 0)
            {
                int kvocient= x/y;
                int ostanek =  x - kvocient * y;
                int Q = kvocient * y + ostanek;
                           
                x = y;
                y = ostanek;

                //Curly Brackets ti pomagajo sami convertat iz int v string
                Console.WriteLine("X je enako {0}, Y je enako {1}",x, y);
            }
            //Vrne Ostanek preden vrne Odgovor v počasnejši verziji
            return x;

        
        }
        //Recursive verzija, ki preskoči vmesne korake
        public static int NSDRecursive(int x, int y){
            if (x==y || y==0){
                return x;
            }
            int ostanek = x - (x/y) * y;
            return NSDRecursive(y, ostanek);
        }
    }       
}