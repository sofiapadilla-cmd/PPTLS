using PPTLS.Strategies;

namespace PPTLS.Models;

public class Jugador
{
    //AQUÍ FALTA ALGO
    public string Nombre {get;set;}
    public IJugada JugadaActual {get;set;}

    public Jugador(string nombre)
    {
     Nombre = nombre;   
    }

    public void ElegirJugada(IJugada jugada)
    {
        JugadaActual = jugada;
    }
}
