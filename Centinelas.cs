using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace programasVS
{
    public class Centinelas : Agentes
    
    {
        public int niveldecontrol {get; set;}

        public void Barreras (){
            WriteLine ("Puso barrera");
        }
    }
}