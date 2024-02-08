using System;
using programasVS.obj;
using static System.Console;
namespace programasVS
{
class Program
{
static void Main (string[] args)
{
   /* WriteLine("Hola mundo");
    zoologico cloeland = new zoologico(5,2,3);
    cloeland.alimentaranimales();
    */
    
    Duelistas oDuelistas = new Duelistas();
    oDuelistas.Escudos();
    oDuelistas.Nombre_Agente = "iso";
    oDuelistas.daño = 1;
    WriteLine(oDuelistas.Nombre_Agente);

    Centinelas oCentinela = new Centinelas();
    oCentinela.Barreras();
    oCentinela.Nombre_Agente = "KYO";
    oCentinela.niveldecontrol = 2;

}
}
}   